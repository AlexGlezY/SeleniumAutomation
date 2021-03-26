package com.assertions.junit 1;

import org.junit.AfterClass;
import org.junit.Assert;
import org.junit.BeforeClass;
import org.junit.Test;
import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;

public class AssertionDemo1
{

    public static WebDriver driver;

    @BeforeClass
    public static void openBrowser()
    {
        System.setProperty("webdriver.chrome.driver", "D:\\AutomationPractice\\chromedriver_win32\\chromedriver.exe");
        driver = new ChromeDriver();
        driver.manage().window().maximize();
    }

    @Test
    public void assertURL()
    {
        driver.get("http://any-api.com/");

        String actualURL = driver.getCurrentUrl();
        System.out.println(actualURL);

        String expectedURL = "http://any-api.com/";

        Assert.assertTrue("URL does not match", expectedURL.equals(actualURL));
        System.out.println("Test Passed");

    }


    @AfterClass
    public static void closeBrowser()
    {
        driver.close();
    }
}