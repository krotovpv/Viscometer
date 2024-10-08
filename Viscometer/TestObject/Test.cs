using System;
using System.Data;
using Viscometer.Response;

namespace Viscometer.TestObject
{
    public class Test
    {
        public int IdTest { get; private set; }
        public DateTime? DateStartTest { get; private set; }
        public int IdOrder { get; private set; }
        public string NumOrder { get; private set; }
        public int IdCompound { get; private set; }
        public string NameCompound { get; private set; }
        public int IdStatus { get; private set; }
        public int NumLoad { get; private set; }
        public string  StartString { get; private set; } = string.Empty;
        public string EndString { get; private set; } = string.Empty;
        public Program LoadedProgram { get; private set; }
        public string LoadedProgramString { get; private set; } = string.Empty;
        public EType Type { get; private set; }
        public RotorType RotorSize { get; private set; }
        public string FactoryNumStand { get; private set; }
        /// <summary>
        /// Испытание наделено истатусом "архивное" (можно только читать но не вносить изменения)
        /// </summary>
        public bool IsArchive { get; set; } = false;

        /// <summary>
        /// Upload an existing test 
        /// </summary>
        /// <param name="IdTest">Id test</param>
        public Test(int IdTest)
        {
            LoadTest(IdTest);
        }

        /// <summary>
        /// Upload new test
        /// </summary>
        /// <param name="IdOrder">Идентификатор заказа</param>
        /// <param name="IdCompound">Идентификатор компаунда</param>
        /// <param name="NumLoad">Номер загрузки</param>
        public Test(int IdOrder, int IdCompound, string NumLoad)
        {
            DataTable dt = DataBase.GetData("" +
                "INSERT INTO [dbo].[Tests] " +
                    "([idOrder],[idCompound],[numLoad]) " +
                "VALUES " +
                    $"('{IdOrder}','{IdCompound}','{NumLoad}') " +
                "SELECT SCOPE_IDENTITY()");
            LoadTest(Convert.ToInt32(dt.Rows[0].ItemArray[0]));
        }

        private void LoadTest(int idTest)
        {
            IdTest = idTest;
            DataRow dataRowTest = DataBase.GetData("" +
                "SELECT " +
                    "Tests.dateStartTest, Tests.idOrder, Tests.idCompound, Tests.idStatus, Tests.numLoad, Tests.startString, Tests.endString, Tests.loadProgramm, Compounds.nameCompound, Orders.numOrder " +
                "FROM Compounds INNER JOIN " +
                    "Tests ON Compounds.idCompound = Tests.idCompound INNER JOIN " +
                    "Orders ON Tests.idOrder = Orders.idOrder " +
                $"WHERE (Tests.idTest = '{idTest}')").Rows[0];

            if (dataRowTest["dateStartTest"] == DBNull.Value)
                DateStartTest = null;
            else
                DateStartTest = Convert.ToDateTime(dataRowTest["dateStartTest"]);

            IdOrder = Convert.ToInt32(dataRowTest["idOrder"]);
            IdCompound = Convert.ToInt32(dataRowTest["idCompound"]);
            IdStatus = Convert.ToInt32(dataRowTest["idStatus"]);
            NumLoad = Convert.ToInt32(dataRowTest["numLoad"]);
            StartString = dataRowTest["startString"].ToString();
            EndString = dataRowTest["endString"].ToString();
            LoadedProgramString = dataRowTest["loadProgramm"].ToString();
            NumOrder = dataRowTest["numOrder"].ToString();
            NameCompound = dataRowTest["nameCompound"].ToString();
        }

        public void SetStartResponse(StartResponse startResponse)
        {
            LoadedProgram = startResponse.Programm;
            FactoryNumStand = startResponse.FactoryNumber;

            if (IsArchive)
            {
                LoadTest(IdTest);
            }
            else
            {
                if (IdStatus == (int)EStatus.Blank)
                {
                    DataBase.GetData("" +
                        "UPDATE [dbo].[Tests] " +
                        "SET " +
                            $"[dateStartTest] = '{DateTime.Now}'," +
                            $"[idStatus] = '{(int)EStatus.Work}'," +
                            $"[loadProgramm] = '{LoadedProgram.ToString()}'," +
                            $"[startString] = '{startResponse.FullString}' " +
                        "WHERE " +
                            $"[idTest] = '{IdTest}'");
                    LoadTest(IdTest);
                }
                else
                {
                    NumLoad++;
                    DataTable dt = DataBase.GetData("" +
                        "INSERT INTO [dbo].[Tests] " +
                            "([dateStartTest],[idOrder],[idCompound],[numLoad],[idStatus],[loadProgramm],[startString]) " +
                        "VALUES " +
                            $"('{DateTime.Now}','{IdOrder}','{IdCompound}','{NumLoad}','{(int)Test.EStatus.Work}','{LoadedProgramString}','{startResponse.FullString}') " +
                        "SELECT SCOPE_IDENTITY()");
                    LoadTest(Convert.ToInt32(dt.Rows[0].ItemArray[0]));
                }
            }
        }

        public void SetEndResponse(EndResponse endResponse)
        {
            if (!IsArchive)
            {
                if (endResponse.Status == 1)
                {
                    DataBase.GetData("" +
                        $"UPDATE [dbo].[Tests] SET " +
                            $"[idStatus] = '{(int)Test.EStatus.Success}'," +
                            $"[endString] = '{endResponse.FullString}' " +
                        "WHERE " +
                            $"[idTest] = '{IdTest}'");
                }
                else if (endResponse.Status == 2)
                {
                    DataBase.GetData("" +
                        "UPDATE [dbo].[Tests] SET " +
                            $"[idStatus] = '{(int)Test.EStatus.Fail}', [endString] = '{endResponse.FullString}' " +
                        "WHERE " +
                            $"[idTest] = '{IdTest}'");
                }
            }
        }

        public void SetBreakTest()
        {
            int status = Convert.ToInt16(DataBase.GetData($"SELECT idStatus FROM [dbo].[Tests] WHERE idTest = '{IdTest}'").Rows[0]["idStatus"]);
            if (status == (int)Test.EStatus.Work) DataBase.GetData($"UPDATE [dbo].[Tests] SET [idStatus] = '{(int)Test.EStatus.Fail}' WHERE [idTest] = '{IdTest}'");
        }

        /// <summary>
        /// Сохранить полученую от стенда строку
        /// </summary>
        /// <param name="responseString">Строка ответа от стенда</param>
        public void SaveResponse(string responseString)
        {
            if (IsArchive) return;

            DataBase.GetData($"INSERT INTO [dbo].[ProcessResponses] ([idTest],[stringFromStand]) VALUES ('{IdTest}' ,'{responseString}')");
        }

        /// <summary>
        /// Извлечь все ответы от стенда в строковом представлении собраные в таблицу
        /// </summary>
        /// <returns>Таблица строк ответов от стенда</returns>
        public DataTable GetArchiveData()
        {
            return DataBase.GetData($"SELECT stringFromStand, timeStamp FROM [dbo].[ProcessResponses] WHERE idTest = '{IdTest}' ORDER BY [timeStamp] ASC");
        }

        /// <summary>
        /// Тип испытания
        /// </summary>
        public enum EType
        {
            Viscosity,
            Scorch
        }

        /// <summary>
        /// Статус испытания
        /// </summary>
        public enum EStatus
        {
            /// <summary>
            /// Испытание не проводилось
            /// </summary>
            Blank = 1,
            /// <summary>
            /// Испытание провалено
            /// </summary>
            Fail = 2,
            /// <summary>
            /// Испытание завершилось успешно
            /// </summary>
            Success = 3,
            /// <summary>
            /// Результат испытания принят испытателем
            /// </summary>
            Handshake = 4,
            /// <summary>
            /// Результат испытания отброшен испытателем
            /// </summary>
            Ignor = 5,
            /// <summary>
            /// Испытание в процессе
            /// </summary>
            Work = 6
        }
    }
}
