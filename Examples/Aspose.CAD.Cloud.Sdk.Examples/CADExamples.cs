using Aspose.CAD.Cloud.Sdk;
using Aspose.CAD.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.CAD.Cloud.Sdk.Api;

namespace Aspose.CAD.Cloud.Sdk.Examples
{
    class CADExamples
    {
        protected string AppKey = ""; // Get App Key and App SID from https://dashboard.aspose.cloud/
        protected string AppSid = ""; // Get App Key and App SID from https://dashboard.aspose.cloud/

        static void Main(string[] args)
        {
            CADExamples cadExamples = new CADExamples();

            // Change scale of an existing image
            cadExamples.GetImageResize();

            // Change scale of an image from body
            cadExamples.PostImageResize();

            // Get properties of an image
            cadExamples.GetImageProperties();

            // Rotate and flip existing image
            cadExamples.GetImageRotateFlip();

            // Rotate and flip existing image and get it from response
            cadExamples.PostImageRotateFlip();

            // Export existing drawing to another format
            cadExamples.GetImageSaveAs();

            // Export existing image to another format. Image is passed as request body
            cadExamples.PostImageSaveAs();
        }

        // Change Scale of an existing image
        private void GetImageResize()
        {
            var cadApi = new CadApi(AppKey, AppSid);

            string fileName = "910609.dxf";
            // Possible values are jpg, bmp, psd, tiff, gif, png, j2k, wmf and pdf
            string formatToExport = "pdf";
            int? newWidth = 100;
            int? newHeight = 150;
            string destFileName = "910609.pdf";

            // Upload document to Cloud Storage
            uploadFileToCloudStorage(fileName);

            var request = new GetDrawingResizeRequest(fileName, formatToExport, newWidth, newHeight, null, null, null);
            var responseStream = cadApi.GetDrawingResize(request);

            // Save the output file to disk
            saveFileToDisk(responseStream, destFileName);
        }

        // Change scale of an image from body
        private void PostImageResize()
        {
            var cadApi = new CadApi(AppKey, AppSid);
            string fileName = "910609.dxf";
            // Possible values are jpg, bmp, psd, tiff, gif, png, j2k, wmf and pdf
            string formatToExport = "pdf";
            int? newWidth = 100;
            int? newHeight = 150;
            string dataFilePath = Path.Combine(pathToDataDir(), fileName);
            string destFileName = "910609.pdf";

            var request = new PostDrawingResizeRequest(File.OpenRead(dataFilePath), formatToExport, newWidth, newHeight, null, null);
            var responseStream = cadApi.PostDrawingResize(request);

            // Save the output file to disk
            saveFileToDisk(responseStream, destFileName);
        }

        // Get properties of an image
        private void GetImageProperties()
        {
            var cadApi = new CadApi(AppKey, AppSid);
            string fileName = "910609.dxf";

            // Upload document to Cloud Storage
            uploadFileToCloudStorage(fileName);

            var request = new GetDrawingPropertiesRequest(fileName, null, null);
            var properties = cadApi.GetDrawingProperties(request);
        }

        // Rotate and flip existing image
        private void GetImageRotateFlip()
        {
            var cadApi = new CadApi(AppKey, AppSid);
            string fileName = "910609.dxf";
            // Possible values are jpg, bmp, psd, tiff, gif, png, j2k, wmf and pdf
            string formatToExport = "pdf";
            // Possible values are Rotate180FlipNone, Rotate180FlipX, Rotate180FlipXY, Rotate180FlipY, Rotate270FlipNone, 
            // Rotate270FlipX, Rotate270FlipXY, Rotate270FlipY, Rotate90FlipNone, Rotate90FlipX, Rotate90FlipXY, 
            // Rotate90FlipY, RotateNoneFlipNone, RotateNoneFlipX, RotateNoneFlipXY and RotateNoneFlipY
            var method = "Rotate180FlipNone";
            string destFileName = "910609.pdf";

            // Upload document to Cloud Storage
            uploadFileToCloudStorage(fileName);

            var request = new GetDrawingRotateFlipRequest(fileName, formatToExport, method, null, null, null);
            var responseStream = cadApi.GetDrawingRotateFlip(request);

            // Save the output file to disk
            saveFileToDisk(responseStream, destFileName);
        }

        // Rotate and flip existing image and get it from response
        private void PostImageRotateFlip()
        {
            var cadApi = new CadApi(AppKey, AppSid);
            string fileName = "01.026.385.01.0.I SOPORTE ENFRIADOR.dwg";
            // Possible values are jpg, bmp, psd, tiff, gif, png, j2k, wmf and pdf
            string formatToExport = "pdf";
            // Possible values are Rotate180FlipNone, Rotate180FlipX, Rotate180FlipXY, Rotate180FlipY, Rotate270FlipNone, 
            // Rotate270FlipX, Rotate270FlipXY, Rotate270FlipY, Rotate90FlipNone, Rotate90FlipX, Rotate90FlipXY, 
            // Rotate90FlipY, RotateNoneFlipNone, RotateNoneFlipX, RotateNoneFlipXY and RotateNoneFlipY
            var method = "Rotate180FlipNone";
            string destFileName = "01.026.385.01.0.I SOPORTE ENFRIADOR.pdf";
            string dataFilePath = Path.Combine(pathToDataDir(), fileName);

            var request = new PostDrawingRotateFlipRequest(File.OpenRead(dataFilePath), formatToExport, method, null);
            var responseStream = cadApi.PostDrawingRotateFlip(request);

            // Save the output file to disk
            saveFileToDisk(responseStream, destFileName);
        }

        // Export existing drawing to another format
        private void GetImageSaveAs()
        {
            var cadApi = new CadApi(AppKey, AppSid);
            string fileName = "01.026.385.01.0.I SOPORTE ENFRIADOR.dwg";
            // Possible values are jpg, bmp, psd, tiff, gif, png, j2k, wmf and pdf
            string formatToExport = "pdf";
            string destFileName = "01.026.385.01.0.I SOPORTE ENFRIADOR.pdf";

            // Upload document to Cloud Storage
            uploadFileToCloudStorage(fileName);

            var request = new GetDrawingSaveAsRequest(fileName, formatToExport, null, null, null);
            var responseStream = cadApi.GetDrawingSaveAs(request);

            // Save the output file to disk
            saveFileToDisk(responseStream, destFileName);
        }

        // Export existing image to another format. Image is passed as request body
        private void PostImageSaveAs()
        {
            var cadApi = new CadApi(AppKey, AppSid);
            string fileName = "01.026.385.01.0.I SOPORTE ENFRIADOR.dwg";
            // Possible values are jpg, bmp, psd, tiff, gif, png, j2k, wmf and pdf
            string formatToExport = "pdf";
            string dataFilePath = Path.Combine(pathToDataDir(), fileName);
            string destFileName = "01.026.385.01.0.I SOPORTE ENFRIADOR.pdf";

            var request = new PostDrawingSaveAsRequest(File.OpenRead(dataFilePath), formatToExport, null, null);
            var responseStream = cadApi.PostDrawingSaveAs(request);

            // Save the output file to disk
            saveFileToDisk(responseStream, destFileName);
        }

        private string pathToDataDir()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            var folders = Path.GetDirectoryName(baseDirectory).Split('\\').ToList();
            // Get Path to the TestData directory
            var foldersUpToRootDir = folders.Take(folders.Count - 5);
            var pathToRootDir = string.Join("\\", foldersUpToRootDir);
            return Path.Combine(pathToRootDir, "TestData");
        }

        private void uploadFileToCloudStorage(String fileName)
        {
            var cadApi = new CadApi(AppKey, AppSid);

            string dataFilePath = Path.Combine(pathToDataDir(), fileName);

            var putCreateRequest = new UploadFileRequest(fileName, File.OpenRead(dataFilePath), null);
            cadApi.UploadFile(putCreateRequest);
        }

        private void saveFileToDisk(Stream responseStream, String destFileName)
        {
            var fileStream = File.Create(Path.Combine(pathToDataDir(), "Output", destFileName));
            responseStream.Seek(0, SeekOrigin.Begin);
            responseStream.CopyTo(fileStream);
            fileStream.Close();
        }
    }
}
