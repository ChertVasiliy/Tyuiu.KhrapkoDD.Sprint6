using Tyuiu.KhrapkoDD.Sprint6.Task7.V11.Lib;

namespace Tyuiu.KhrapkoDD.Sprint6.Task7.V11.Test
{
    [TestFixture]
    public class LibTests
    {
        [Test]
        public void ProcessFifthRow_ReplacesNegativesWith9()
        {
            var src = new DataGridView();
            src.Columns.Add("A", "A");
            src.Columns.Add("B", "B");

            // 4 строки обычных + 1 интересующая нас
            src.Rows.Add("1", "2");
            src.Rows.Add("3", "4");
            src.Rows.Add("-5", "6");
            src.Rows.Add("7", "8");
            src.Rows.Add("-9", "-10"); // 5 строка, индекс 4

            var dst = new DataGridView();

            DataService.ProcessFifthRow(src, dst);

            Assert.AreEqual("9", dst.Rows[4].Cells[0].Value.ToString());
            Assert.AreEqual("9", dst.Rows[4].Cells[1].Value.ToString());
            Assert.AreEqual("7", dst.Rows[3].Cells[0].Value.ToString()); // проверка, что др. строки не тронуты
        }
    }
}