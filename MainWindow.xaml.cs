using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Excel= Microsoft.Office.Interop.Excel;
//using Microsoft.Office.Interop.Excel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void T1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        

        private void Info_Copy_MouseEnter(object sender, MouseEventArgs e)
        {
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            {
                string information = Info.Text;
                try
                {
                    string[] InfoArr = information.Split('\n');
                    Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                    if (xlApp == null)
                    {
                        MessageBox.Show("Excel is not properly installed!!");
                        return;
                    }

                    Excel.Workbook xlWorkBook;
                    Excel.Worksheet xlWorkSheet;
                    object misValue = System.Reflection.Missing.Value;

                    xlWorkBook = xlApp.Workbooks.Add(misValue);
                    xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);



                    string NameOfCar = InfoArr[0];
                    string[] InfoOfUser = InfoArr[1].Split(' ');
                    string NameOfUser = InfoOfUser[0];
                    string LNameOfUser = InfoOfUser[1];
                    string IdCode = InfoOfUser[2];

                    string CarCode = InfoArr[2];
                    bool B1 = int.TryParse(CarCode.Substring(0, 2), out int n);
                    bool B2 = int.TryParse(CarCode.Substring(3), out int m);
                    bool B3 = char.IsUpper(CarCode[2]);

                    if (!B1 || !B2 || !B3)
                    {
                        Console.WriteLine("the problem");
                        throw new Exception("Your PelakNumber is invalid");
                    }
                    string ProdectDate = InfoOfUser[3];
                    string[] Passengers = InfoOfUser[4].Split(' ');
                    string SeatNumber = Passengers[0];
                    bool B4 = int.TryParse(SeatNumber, out int NP);
                    if (!B4)
                        throw new Exception("Invalid Number of Passengers");

                    string[] AgeOfPassengers = new string[NP];
                    try
                    {
                        for (int i = 0; i < NP; i++)
                        {
                            AgeOfPassengers[i] = Passengers[i + 1];

                        }
                    }
                    catch { }

                    xlWorkBook.SaveAs("d:\\csharp-Excel.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();
                }

                catch
                {
                    MessageBox.Show("Saved");
                }

            }

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
 
        }
    }
}
