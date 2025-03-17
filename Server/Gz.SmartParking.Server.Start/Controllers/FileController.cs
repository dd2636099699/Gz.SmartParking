using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Gz.SmartParking.Server.ICommon;
using Gz.SmartParking.Server.IService;
using Gz.SmartParking.Server.Models;

namespace Gz.SmartParking.Server.Start.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/[action]")]
    public class FileController
    {
        IConfigration _configuration;
        IFileUpgradeService _fileUpgradeService;
        public FileController(IConfigration configuration, IFileUpgradeService fileUpgradeService)
        {
            _configuration = configuration;
            _fileUpgradeService = fileUpgradeService;
        }
        /// 提供文件相关的服务
        /// 上传、下载
        /// 
        //[HttpPost]
        //[Route("download")]
        //public IActionResult Download([FromForm] IFormCollection formCollection)
        //{
        //    var fileName = formCollection["filename"]; //文件名
        //    var filePath = Path.Combine(_configuration.Read("FileFolder"), fileName); //文件所在路径
        //    ResFileStream fs = new ResFileStream(filePath, FileMode.Open, FileAccess.Read);

        //    var type = new MediaTypeHeaderValue("application/oct-stream").MediaType;
        //    //enableRangeProcessing 是否启动断点续传
        //    return File(fs, contentType: type, fileName, enableRangeProcessing: true);
        //}


        [HttpGet]
        public JsonResult Check()
        {
            var result = _fileUpgradeService.Query<UpgradeFile>(f => f.FileId > 0);// EFCore
            // 从数据库获取相关的文件信息   文件名-文件MD5
            return new JsonResult(result);
        }
    }
}
