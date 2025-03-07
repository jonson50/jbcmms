﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Contracts
{
    public interface IAssetRepository
    {
        IEnumerable<Asset> GetAllAssets(bool trackChanges);
    }
}
