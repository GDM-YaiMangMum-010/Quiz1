using System;
public class Converter
{
    public static int ConvertStringToInt(string value){
        if(int.TryParse(value,out int number)){
            return number;
        }
        throw new Exception("Wrong Word");
    }
    public static long ConvertStringToLong(string value){
        if(long.TryParse(value,out long number)){
            return number;
        }
        throw new Exception("Wrong Word");
    }
        public static double ConvertStringToDouble(string value){
        if(double.TryParse(value,out double number)){
            return number;
        }
        throw new Exception("Wrong Word");
    }
}