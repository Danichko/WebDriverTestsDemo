using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//Create New Crome Browser Instance
var driver = new ChromeDriver();

//Navigate to Wikipedia

driver.Url = "https://wikipedia.org";

Console.WriteLine("Current Title : " + driver.Title);

//Locate search field by ID

var searchField = driver.FindElement(By.Id("searchInput"));

//Click on Element
searchField.Click();
searchField.SendKeys("Quality Assurance" + Keys.Enter);

Console.WriteLine("Title After Search : " + driver.Title);

//Close browser

driver.Quit();