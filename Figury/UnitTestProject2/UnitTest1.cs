﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FiguryLibrary;

namespace UnitTestProject2
{
    [TestClass]

    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(3, 4, 5)]
        [DataRow(2, 3, 4)]
        [DataRow(1, 1, 1)]
        public void ConstruktorPoprawneDaneTrojkatUtwozony(double a, double b, double c)
        {
            //AAA
            //Arrange

            //Act
            Trojkat t = new Trojkat(a, b, c);

            //Assert
            Assert.AreEqual(a, t.A);
            Assert.AreEqual(b, t.B);
            Assert.AreEqual(c, t.C);
        }

        [TestMethod]

        public void ConstructorDifaultePoprawnie()
        {
            //Arrange

            //Act
            Trojkat t = new Trojkat();

            //Assert
            Assert.AreEqual(1, t.A);
            Assert.AreEqual(1, t.B);
            Assert.AreEqual(1, t.C);
        }

       /* [DataTestMethod]
        [DataRow(-1,1,1)]
        [DataRow(1,-1,1)]
        [DataRow(1,1,-1)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
       /*public void ConstructorUjemnyParametr_ArgumentOutOfRangeExeption(double a, double b, double c)
        {
            Trojkat t = new Trojkat(a, b, c);
        } */
        
       /* [DataTestMethod]
        [DataRow(1,1,100)]
        [DataRow(100,1,1)]
        [DataRow(1,100,1)]
        [ExpectedException(typeof(ArgumentException))]

       /* public void ConstructorNieSpelnionyWarunekTrojkata_ArgumentExeption(double a, double b, double c)
        {
            Trojkat t = new Trojkat(a, b, c);

        }*/

        [DataTestMethod]
        [DataRow(1,1,1,3)]
        [DataRow(3,4,5,12)]

        public void PropertyObwod_Poprawnie(double a, double b, double c, double wynik )
        {
            // Act
            var t = new Trojkat(a, b, c);


            // Assert
            Assert.AreEqual(wynik, t.Obwod);

        }

        [DataTestMethod] 
        [DataRow(3,4,5,6)]
        [DataRow(1,1,1,0.433012701899219)]

        public void PropertyPole_Poprawnie(double a, double b, double c, double wynik)
        {
            // Act
            var t = new Trojkat(a, b, c);

            //Assert

            Assert.AreEqual(wynik, t.Pole);
        }



    }
}
