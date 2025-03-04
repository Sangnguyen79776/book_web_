﻿
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System;
using book_web.Data;

using book_web.Models;

namespace book_web.Middleware
{
    public class ActivityLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ActivityLoggingMiddleware> _logger;

        public ActivityLoggingMiddleware(RequestDelegate next, ILogger<ActivityLoggingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, Book_webContext dbContext)
        {
            var startTime = DateTime.Now;

            await _next(context);  // Process the request

            var duration = DateTime.Now - startTime;
            var user = context.User.Identity?.Name ?? "Anonymous";

            // Create a new log entry
            var log = new ActivityLog
            {
                UserName = user,
                Path = context.Request.Path,
                AccessedAt = DateTime.Now,
                DurationMs = duration.TotalMilliseconds
            };

            // Save the log entry to the database
            dbContext.ActivityLogs.Add(log);
            await dbContext.SaveChangesAsync();
        }
    }
}
