using GdUnit4;
using static GdUnit4.Assertions;
using TiercelFoundry.GodotUtils;
using FileAccess = Godot.FileAccess;
using Godot;

namespace GodotUtils.Tests;

[TestSuite]
public class FileAccessTests
{
    private string _filePath = "";

    [BeforeTest]
    public void BeforeTest()
    {
        _filePath = Path.GetTempFileName();
    }


    [AfterTest]
    public void AfterTest()
    {
        File.Delete(_filePath);
    }

    [TestCase]
    public void GetIntStoreInt()
    {
        int[] nums = { 10, 0, 1, -1, int.MaxValue, int.MinValue, 42, -69 };

        using (var file = FileAccess.Open(_filePath, FileAccess.ModeFlags.Write))
        {
            for (int i = 0; i < nums.Length; i++)
            {
                file.StoreInt(nums[i]);
            }
        }

        using (var file = FileAccess.Open(_filePath, FileAccess.ModeFlags.Read))
        {
            AssertThat(file.GetInt()).IsEqual(10);
            AssertThat(file.GetInt()).IsEqual(0);
            AssertThat(file.GetInt()).IsEqual(1);
            AssertThat(file.GetInt()).IsEqual(-1);
            AssertThat(file.GetInt()).IsEqual(int.MaxValue);
            AssertThat(file.GetInt()).IsEqual(int.MinValue);
            AssertThat(file.GetInt()).IsEqual(42);
            AssertThat(file.GetInt()).IsEqual(-69);
        }
    }

    [TestCase]
    public void GetBoolStoreBool()
    {
        using (var file = FileAccess.Open(_filePath, FileAccess.ModeFlags.Write))
        {
            file.StoreBool(true);
            file.StoreBool(false);
        }

        using (var file = FileAccess.Open(_filePath, FileAccess.ModeFlags.Read))
        {
            AssertThat(file.GetBool(), true);
            AssertThat(file.GetBool(), false);
        }
    }

    [TestCase]
    public void GetVector2IStoreVector2I()
    {
        using (var file = FileAccess.Open(_filePath, FileAccess.ModeFlags.Write))
        {
            Vector2I[] vecs = 
            {
                Vector2I.Up,
                Vector2I.Zero,
                Vector2I.One,
                new Vector2I(-1, -1),
                new Vector2I(int.MaxValue, int.MinValue)
            };
            
            for (int i = 0; i < vecs.Length; i++)
            {
                file.StoreVector2I(vecs[i]);
            }
        }

        using (var file = FileAccess.Open(_filePath, FileAccess.ModeFlags.Read))
        {
            AssertThat(file.GetVector2I(), Vector2I.Up);
            AssertThat(file.GetVector2I(), Vector2I.Zero);
            AssertThat(file.GetVector2I(), Vector2I.One);
            AssertThat(file.GetVector2I(), new Vector2I(-1, -1));
            AssertThat(file.GetVector2I(), new Vector2I(int.MaxValue, int.MinValue));
        }
    }
}