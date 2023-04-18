using Common.Utilities;

namespace Artifacts;

public class BuildContext : BuildContextBase
{
    public string MsBuildConfiguration { get; } = Constants.DefaultConfiguration;

    public bool IsDockerOnLinux { get; set; }

    public bool TestArm64Artifacts { get; set; }

    public Architecture? Architecture { get; set; }

    public IEnumerable<DockerImage> Images { get; set; } = new List<DockerImage>();

    public BuildContext(ICakeContext context) : base(context)
    {
    }
}
