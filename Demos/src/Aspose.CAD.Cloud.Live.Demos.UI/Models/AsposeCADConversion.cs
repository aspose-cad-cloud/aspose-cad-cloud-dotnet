using System.Threading.Tasks;
using System.IO;
using System.Web.Http;
using Aspose.CAD.Cloud.Live.Demos.UI.Models;
using System.Diagnostics;
using Aspose.CAD.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json.Linq;

namespace Aspose.CAD.Cloud.Live.Demos.UI.Models
{
    ///<Summary>
    /// Aspose.CAD Cloud API convert method to convert word document file to other format
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
                var request = new GetDrawingSaveAsRequest(fileName, formatToExport, null, null, null);
                var stream = cadApi.GetDrawingSaveAs(request);

                stream.Position = 0;
                var putCreateRequest = new UploadFileRequest(outputFileName, stream, null);
                cadApi.UploadFile(putCreateRequest);
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
