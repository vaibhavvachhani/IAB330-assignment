using fishy.Models;
using fishy.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestFixture]
    public class Test1
    {
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }

        [Test]
        public async System.Threading.Tasks.Task FirstTestAsync()
        {


            //arrange
            var data = await WeatherService.GetWeatherInfo(-27.50, 153.075);

            //act
            Assert.IsTrue(data is WeatherInfo);


            //assert
        }

        [Test]
        public async System.Threading.Tasks.Task ValidTemperature1()
        {
            //arrange
            var data = await WeatherService.GetWeatherInfo(-27.50, 153.075);

            //act
            
            Assert.IsTrue(data.Main.Temp > -459.67); //lowest possible
           

        }

        [Test]
        public async System.Threading.Tasks.Task ValidTemperature2()
        {
            //arrange
            var data = await WeatherService.GetWeatherInfo(-27.50, 153.075);

            //act
            Assert.IsTrue(data.Main.TempMax < 990000000000000.0); //highest possible
                                                     

            //assert

        }

        [Test]
        public async System.Threading.Tasks.Task ValidPressure()
        {
            //arrange
            var data = await WeatherService.GetWeatherInfo(-27.50, 153.075);

            //act
            Assert.IsTrue(data.Main.Pressure != 0.0); //highest possible


            //assert

        }


        [Test]
        public async System.Threading.Tasks.Task ValidHumidity()
        {
            //arrange
            var data = await WeatherService.GetWeatherInfo(-27.50, 153.075);

            //act
            Assert.IsTrue(data.Main.Humidity != 0.0); //highest possible


            //assert

        }

    }
}
