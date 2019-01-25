using Aspose.CAD.Cloud.Sdk;
using Aspose.CAD.Cloud.Sdk.Client;
using Aspose.CAD.Cloud.Sdk.Model.Requests;
using Aspose.Storage.Cloud.Sdk.Api;
using Aspose.Storage.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aspose.CAD_Cloud_APIs_Examples
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
            CADApi cadApi = new CADApi(AppKey, AppSid);

            string fileName = "910609.dxf";
            // Possible values are jpg, bmp, psd, tiff, gif, png, j2k, wmf and pdf
            string formatToExport = "pdf";
            int? newWidth = 100;
            int? newHeight = 150;
            string destFileName = "910609.pdf";

            // Upload document to Cloud Storage
            uploadFileToCloudStorage(fileName);

            var request = new GetChangeImageScaleRequest(fileName, formatToExport, newWidth, newHeight, null, null, null);
            var responseStream = cadApi.GetChangeImageScale(request);

            // Save the output file to disk
            saveFileToDisk(responseStream, destFileName);
        }

        // Change scale of an image from body
        private void PostImageResize()
        {
            CADApi cadApi = new CADApi(AppKey, AppSid);
            string fileName = "910609.dxf";
            // Possible values are jpg, bmp, psd, tiff, gif, png, j2k, wmf and pdf
            string formatToExport = "pdf";
            int? newWidth = 100;
            int? newHeight = 150;
            string dataFilePath = Path.Combine(pathToDataDir(), fileName);
            string destFileName = "910609.pdf";

            var request = new PostChangeImageScaleRequest(File.OpenRead(dataFilePath), formatToExport, newWidth, newHeight, null, null);
            var responseStream = cadApi.PostChangeImageScale(request);

            // Save the output file to disk
            saveFileToDisk(responseStream, destFileName);
        }

        // Get properties of an image
        private void GetImageProperties()
        {
            CADApi cadApi = new CADApi(AppKey, AppSid);
            string fileName = "910609.dxf";

            // Upload document to Cloud Storage
            uploadFileToCloudStorage(fileName);

            var request = new GetImagePropertiesRequest(fileName, null, null);
            var properties = cadApi.GetImageProperties(request);
        }

        // Rotate and flip existing image
        private void GetImageRotateFlip()
        {
            CADApi cadApi = new CADApi(AppKey, AppSid);
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

            var request = new GetImageRotateFlipRequest(fileName, formatToExport, method, null, null, null);
            var responseStream = cadApi.GetImageRotateFlip(request);

            // Save the output file to disk
            saveFileToDisk(responseStream, destFileName);
        }

        // Rotate and flip existing image and get it from response
        private void PostImageRotateFlip()
        {
            CADApi cadApi = new CADApi(AppKey, AppSid);
            string fileName = "01.026.385.01.0.I SOPORTE ENFRIADOR.dwg";
            // Possible values are jpg, bmp, psd, tiff, gif, png, j2k, wmf and pdf
            string formatToExport = "pdf";
            // Possible values are Rotate180FlipNone, Rotate180FlipX, Rotate180FlipXY, Rotate180FlipY, Rotate270FlipNone, 
            // Rotate270FlipX, Rotate270FlipXY, Rotate270FlipY, Rotate90FlipNone, Rotate90FlipX, Rotate90FlipXY, 
            // Rotate90FlipY, RotateNoneFlipNone, RotateNoneFlipX, RotateNoneFlipXY and RotateNoneFlipY
            var method = "Rotate180FlipNone";
            string destFileName = "01.026.385.01.0.I SOPORTE ENFRIADOR.pdf";
            string dataFilePath = Path.Combine(pathToDataDir(), fileName);

            var request = new PostImageRotateFlipRequest(File.OpenRead(dataFilePath), formatToExport, method, null);
            var responseStream = cadApi.PostImageRotateFlip(request);

            // Save the output file to disk
            saveFileToDisk(responseStream, destFileName);
        }

        // Export existing drawing to another format
        private void GetImageSaveAs()
        {
            CADApi cadApi = new CADApi(AppKey, AppSid);
            string fileName = "01.026.385.01.0.I SOPORTE ENFRIADOR.dwg";
            // Possible values are jpg, bmp, psd, tiff, gif, png, j2k, wmf and pdf
            string formatToExport = "pdf";
            string destFileName = "01.026.385.01.0.I SOPORTE ENFRIADOR.pdf";

            // Upload document to Cloud Storage
            uploadFileToCloudStorage(fileName);

            var request = new GetImageSaveAsRequest(fileName, formatToExport, null, null, null, null);
            var responseStream = cadApi.GetImageSaveAs(request);

            // Save the output file to disk
            saveFileToDisk(responseStream, destFileName);
        }

        // Export existing image to another format. Image is passed as request body
        private void PostImageSaveAs()
        {
            CADApi cadApi = new CADApi(AppKey, AppSid);
            string fileName = "01.026.385.01.0.I SOPORTE ENFRIADOR.dwg";
            // Possible values are jpg, bmp, psd, tiff, gif, png, j2k, wmf and pdf
            string formatToExport = "pdf";
            string dataFilePath = Path.Combine(pathToDataDir(), fileName);
            string destFileName = "01.026.385.01.0.I SOPORTE ENFRIADOR.pdf";

            var request = new PostImageSaveAsRequest(File.OpenRead(dataFilePath), formatToExport, null, null, null);
            var responseStream = cadApi.PostImageSaveAs(request);

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
            StorageApi storageApi = new StorageApi(AppKey, AppSid);

            string dataFilePath = Path.Combine(pathToDataDir(), fileName);

            PutCreateRequest putCreateRequest = new PutCreateRequest(fileName, File.OpenRead(dataFilePath), null, null);
            storageApi.PutCreate(putCreateRequest);
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
