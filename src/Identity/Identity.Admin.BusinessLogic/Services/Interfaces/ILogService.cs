﻿using Identity.Admin.BusinessLogic.Dtos.Log;
using System;
using System.Threading.Tasks;

namespace Identity.Admin.BusinessLogic.Services.Interfaces
{
    public interface ILogService
    {
        Task<LogsDto> GetLogsAsync(string search, int page = 1, int pageSize = 10);

        Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan);
    }
}