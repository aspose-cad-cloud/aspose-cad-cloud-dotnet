using System.Threading.Tasks;
using System.IO;
using System.Web.Http;
using Aspose.CAD.Cloud.Live.Demos.UI.Models;
using System.Diagnostics;
using Newtonsoft.Json.Linq;

namespace Aspose.CAD.Cloud.Live.Demos.UI.Models
{
    ///<Summary>
    /// Aspose.HTML Cloud API convert method to convert word document file to other format
    ///</Summary>

    public class AsposeCADConversion : AsposeCADCloudBase
    {
        ///<Summary>
        /// Convert method to convert file to other format
        ///</Summary>
        public Response Convert(string fileName, string folderName, string outputType)
        {
            string fileNamewithOutExtension = Path.GetFileNameWithoutExtension(fileName);
            string outputFileName = fileNamewithOutExtension + "." + outputType;
            bool foundSaveOption = true;

            if (outputType == "jpg" || 
                outputType == "bmp" || 
                outputType == "psd" || 
                outputType == "tiff" || 
                outputType == "gif" || 
                outputType == "png" || 
                outputType == "j2k" || 
                outputType == "wmf" || 
                outputType == "pdf")
            {
                string formatToExport = outputType;
                var request = new Aspose.CAD.Cloud.Sdk.Model.Requests.GetImageSaveAsRequest(fileName, formatToExport, null, null, null, null);
                var stream = cadApi.GetImageSaveAs(request);

                stream.Position = 0;
                Aspose.Storage.Cloud.Sdk.Model.Requests.PutCreateRequest putCreateRequest = new Aspose.Storage.Cloud.Sdk.Model.Requests.PutCreateRequest(outputFileName, stream, null, null);
                storageApi.PutCreate(putCreateRequest);
            }
            else
            {
                foundSaveOption = false;
            }

            if (foundSaveOption)
            {

                return new Response
                {
                    FileName = outputFileName,
                    Status = "OK",
                    StatusCode = 200,
                };
            }

            return new Response
            {
                FileName = null,
                Status = "Output type not found",
                StatusCode = 500
            };

        }

    }
}
