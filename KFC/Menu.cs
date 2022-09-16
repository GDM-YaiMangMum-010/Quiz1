using System;
public class Menu
{
    public void Menu1()
    {
        Data data = new Data();
        List_Menu();
        string Choice = Console.ReadLine();
        switch(Choice)
        {
            case "1":
            {
                Console.WriteLine("------ Store information ------");
                Console.WriteLine("Funds : {0}",data.Store_Fund);
                Console.WriteLine("Name : {0}",data.Store_Name);
                Console.WriteLine("Funds : {0}",data.Store_Address);
                Console.WriteLine("------ ----------------- ------");
                break;
            }
            case "2":
            {
                string[] co_name = {"Tawee","Yuthadee","Jame"};
                string[] co_surname = {"Jaideedee","Tangjairein","Lukrongrein"};
                string[] co_id = {"153-698-4561237","742-11-568741","541-772-3215689"};
                Console.WriteLine("------ Co-founder's information ------");
                for (int i = 0;i < data.Num_Founder;i++)
                {
                    Console.WriteLine("{0} | {1} {2} {3}",i+1,co_name[i],co_surname[i],co_id[i]);   
                }
                Console.WriteLine("------ ------------------------ ------");
                break;
            }
            case "3":
            {
                string[] staff_type = {"store staff","store staff","store staff","food delivery staff","food delivery staff"};
                string[] staff_name = {"Chaidee","Norndee","Apaidee","Thumdee","Norndee"};
                string[] staff_surname = {"Lukdee","Jaidee","Reindee","Nrandee","Reibdee"};
                int[] staff_age = {20,18,22,25,23};
                int[] staff_salary = {15000,15000,15000,12500,12500};
                Console.WriteLine("------ staff information ------");
                for (int i = 0;i < data.Num_Staff;i++)
                {
                    Console.WriteLine("{0} | {1} {2} {3} {4}",i+1,staff_type[i],staff_name[i],staff_surname[i],staff_age[i],staff_salary[i]);   
                }
                Console.WriteLine("------ ----------------- ------");
                break;
            }
            case "4":
            {
                int sales_2 = 0,delivery_2 = 0;
                double sale_share_2 = 0;
                int[] sales = {17526,218628};
                double[] sale_Share = {1873.3,1959.025,1996.525,2677.5,2713.2};
                int travel_expenses = 8250;
                int[] delivery_express = {0,0,0,45000,45600};
                Console.WriteLine("------ Store income/expenses information ------");
                for (int i = 0;i < sales.Length;i++)
                {
                    sales_2 = sales_2+sales[i]; 
                }
                for (int i = 0;i < sales.Length;i++)
                {
                    sale_share_2 = sale_share_2+sale_Share[i]; 
                }
                Console.WriteLine("------ ----------------- ------");
                Console.WriteLine("Total monthly income : {0}",sales_2);
                Console.WriteLine("All employee payroll : {0}",sale_share_2);
                Console.WriteLine("balance : {0}",sales_2-sale_share_2);
                Console.WriteLine("------ --------------------------------- ------");
                break;
            }
            default:
            {
                Console.WriteLine("Wrong . . .");
            }
            break;
        }
    }
    public void List_Menu()
    {
        Console.WriteLine("Please select a menu");
        Console.WriteLine("1 - Store information");
        Console.WriteLine("2 - Co-founder's information");
        Console.WriteLine("3 - Store staff information");
        Console.WriteLine("4 - Store income/expenses information");
    }
    public void ChooseInputOutput()
    {
        Console.WriteLine("Please Input Data");
    }
}