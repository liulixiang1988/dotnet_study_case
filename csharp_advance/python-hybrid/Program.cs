// See https://aka.ms/new-console-template for more information

using System.Buffers.Text;
using System.Reflection;
using Python.Runtime;

Console.WriteLine("Hello, World!");
Runtime.PythonDLL = "/Users/lixiangliu/anaconda3/lib/libpython3.10.dylib";
PythonEngine.Initialize();
using (Py.GIL())
{
    Console.WriteLine(Assembly.GetExecutingAssembly().Location);
    dynamic Image = Py.Import("PIL.Image");
    var img = Image.open("ybear3-300x224.jpg");
    Console.WriteLine(img.size);
    img.show();
    img = img.resize(new int[]
    {
        200, 200
    });
    img.show();
    dynamic base64 = Py.Import("base64");
    var b64 = base64.b64encode(img.tobytes());
    Console.WriteLine(b64);
    Console.WriteLine("\n\n------\n\n");
    dynamic np = Py.Import("numpy");
    Console.WriteLine(np.cos(np.pi * 2));

    dynamic sin = np.sin;
    Console.WriteLine(sin(5));

    double c = (double)(np.cos(5) + sin(5));
    Console.WriteLine(c);

    dynamic a = np.array(new List<float> { 1, 2, 3 });
    Console.WriteLine(a.dtype);

    dynamic b = np.array(new List<float> { 6, 5, 4 }, dtype: np.int32);
    Console.WriteLine(b.dtype);

    Console.WriteLine(a * b);
}

Console.WriteLine("exit");
PythonEngine.Shutdown();