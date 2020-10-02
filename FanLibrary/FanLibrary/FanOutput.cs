﻿using System;

namespace FanLibrary
{
    public class FanOutput
    {
        private string _navn;
        private double _temp;
        private double _fugt;
        private int _id;

        public int Id
        {
            get => _id;
            set
            {
                CheckId(value);
                _id = value;
            }
        }

        public string Navn
        {
            get => _navn;
            set
            {
                CheckNavn(value);
                _navn = value;
            }
        }

        public double Temp
        {
            get => _temp;
            set
            {
                CheckTemp(value);
                _temp = value;
            }
        }

        public double Fugt
        {
            get => _fugt;
            set
            {
                CheckFugt(value);
                _fugt = value;
            }
        }

        public void CheckId(int id)
        {
            if (id < 1)
            {
                throw new ArgumentException("Id skal være et positivt tal");
            }
        }

        //Navn, en tekst-streng, min 2 karakterer lang
        public void CheckNavn(string navn)
        {
            if (navn.Length < 2)
            {
                throw new ArgumentException("Navn skal være på 2 eller flere bogstaver");
            }
        }

        //Temp et tal mellem 15 og 25 (målt i grader celsius, 15 <= Temp <= 25) 
        public void CheckTemp(double temp)
        {
            if (temp < 15 || temp > 25)
            {
                throw new ArgumentOutOfRangeException("temp", temp, "temp er ikke indefor godkendt område");

            }
        }

        //Fugt et tal mellem 30 og 80 (relativ fugtighed, 30 <= Fugt <= 80)
        public void CheckFugt(double fugt)
        {
            if (fugt < 30 || fugt > 80)
            {
                throw new ArgumentOutOfRangeException("fugt", fugt, "fugt er ikke indefor godkendt område");

            }
        }
    }
}
