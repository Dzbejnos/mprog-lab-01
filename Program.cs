using System;
using System.IO;

namespace mprog_lab_01
{
    class tezProgram{
        public int tak;
    }
    class Program
    {
        static void Main(string[] args){
            StreamReader sr = null;
        try
        {
            sr = new StreamReader("/home/linuxmin/Desktop/doc");
            Console.WriteLine(sr.ReadToEnd());
        }
        catch(FileNotFoundException ex)
        {
            Console.WriteLine($"File not found {ex.FileName}");
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
        finally
        {
          
                sr?.Close();
        }
        
        }  
        }  
    }


