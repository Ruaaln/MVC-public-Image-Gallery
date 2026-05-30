namespace ImageUpdateAPP.Service;
public class FileService
{
    private readonly IWebHostEnvironment _environment;

    public FileService(IWebHostEnvironment environment)
    {
        _environment = environment;
    }

    public async Task<string> SaveImageAsync(IFormFile file)
    {
        var uploadsFolder = Path.Combine(
            _environment.WebRootPath,
            "images"
        );

        Directory.CreateDirectory(uploadsFolder);

        var fileName = Guid.NewGuid() +
                       Path.GetExtension(file.FileName);

        var filePath = Path.Combine(
            uploadsFolder,
            fileName
        );

        using var stream = new FileStream(filePath, FileMode.Create);

        await file.CopyToAsync(stream);

        return fileName;
    }

    // get all images from the images folder to step step 4
    public List<string> GetAllImages()
    {
        var uploadsFolder = Path.Combine(
            _environment.WebRootPath,
            "images"
        );
        if (!Directory.Exists(uploadsFolder))
        {
            return new List<string>();
        }
        var files = Directory.GetFiles(uploadsFolder);
        return files.Select(Path.GetFileName).ToList();
    }
}