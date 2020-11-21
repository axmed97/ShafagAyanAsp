﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ShafagAyanAsp.Extensions
{
    public static class IFormFileExtension
    {
        public static async Task<string> SaveFileAsync(this IFormFile formFile, string WebRootPath)
        {
            string uniqueId = Guid.NewGuid().ToString();
            string fileName = uniqueId + formFile.FileName;
            string path = WebRootPath + @"\image\" + fileName;
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                await formFile.CopyToAsync(fs);
            }
            return fileName;
        }
    }
}
