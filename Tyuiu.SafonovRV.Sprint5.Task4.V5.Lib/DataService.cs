﻿using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SafonovRV.Sprint5.Task4.V5.Lib
{
    public class DataService : ISprint5Task4V5
    {
        
            public double LoadFromDataFile(string path)
            {
            double x = 1.0;
            double y = 0;
            string strX = File.ReadAllText(path);
                var X = Convert.ToDouble(strX);

            double res =  y = 4.26 * x / Math.Sin(x);
            res = Math.Round(res, 3);
                return res;
            }
        }
    }
