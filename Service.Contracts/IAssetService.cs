﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
    public interface IAssetService
    {
        IEnumerable<AssetDto> GetAllAssets(bool trackChanges);
    }
}
