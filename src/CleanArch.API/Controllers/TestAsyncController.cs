using Microsoft.AspNetCore.Mvc;

namespace CleanArch.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestAsyncController : ControllerBase
{
    // Practicing Async and Task -_-
    [HttpGet("long")]
    public async Task<IActionResult> LongTask()
    {
        Console.WriteLine($"[Long] Start - Thread {Thread.CurrentThread.ManagedThreadId}");
        await Task.Delay(3000);
        Console.WriteLine($"[Long] End - Thread {Thread.CurrentThread.ManagedThreadId}");
        return Ok("Long Task Done");
    }

    [HttpGet("short")]
    public async Task<IActionResult> ShortTask()
    {
        Console.WriteLine($"[Short] Handled - Thread {Thread.CurrentThread.ManagedThreadId}");
        await Task.Delay(5000);
        return Ok("Short task done");        
    }

    [HttpGet("med")]
    public async Task<IActionResult> med()
    {
        Console.WriteLine($"[med] Handle - Thread {Thread.CurrentThread.ManagedThreadId}");
        return Ok("Med Task done");
    }
}