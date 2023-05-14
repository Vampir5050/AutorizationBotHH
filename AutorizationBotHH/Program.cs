using AutorizationBotHH;
using Microsoft.Playwright;
using System.Net;

var user = new User();
using var playwright = await Playwright.CreateAsync();
await using IBrowser browser = await playwright.Firefox.LaunchAsync(
    new BrowserTypeLaunchOptions
    {
        Headless = false
    });
BrowserNewContextOptions device = playwright.Devices["Desktop Firefox"];
await using IBrowserContext context = await browser.NewContextAsync(device);
IPage page = await context.NewPageAsync();
await Login();
async Task Login()
{
    await page.GotoAsync("https://hh.ru/login");
    await page.ClickAsync("button[data-qa ='expand-login-by-password']");
    await page.TypeAsync("input[data-qa='login-input-username']", user.login);
    await page.TypeAsync("input[data-qa='login-input-password']", user.password);
    await page.ClickAsync("button[data-qa ='account-login-submit']");
}


Console.ReadKey();
