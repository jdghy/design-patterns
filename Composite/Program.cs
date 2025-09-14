namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GitComponent mainBranch = new Branch("main");
            GitComponent commitToMain1 = new Commit("82a79d4");
            GitComponent commitToMain2 = new Commit("1c053ff");
            GitComponent commitToMain3 = new Commit("1b5f943");
            GitComponent commitToMain4 = new Commit("b1f9423");
            mainBranch.Add(commitToMain1);
            mainBranch.Add(commitToMain2);
            mainBranch.Add(commitToMain3);
            mainBranch.Add(commitToMain4);

            GitComponent smallFeature = new Branch("small-feature");
            mainBranch.Add(smallFeature);

            GitComponent commitToSmallFeature1 = new Commit("22f71d3");
            smallFeature.Add(commitToSmallFeature1);

            GitComponent bigFeature = new Branch("big-feature");
            mainBranch.Add(bigFeature);

            GitComponent commitToBigFeature1 = new Commit("82a79d4");
            GitComponent commitToBigFeature2 = new Commit("82a79d4");
            GitComponent commitToBigFeature3 = new Commit("82a79d4");
            GitComponent commitToBigFeature4 = new Commit("82a79d4");
            GitComponent commitToBigFeature5 = new Commit("82a79d4");
            GitComponent commitToBigFeature6 = new Commit("82a79d4");
            bigFeature.Add(commitToBigFeature1);
            bigFeature.Add(commitToBigFeature2);
            bigFeature.Add(commitToBigFeature3);
            bigFeature.Add(commitToBigFeature4);
            bigFeature.Add(commitToBigFeature5);
            bigFeature.Add(commitToBigFeature6);

            Console.WriteLine("Small Feature Commit History:");
            Console.WriteLine("-----------------------------");
            smallFeature.ShowDetail();

            Console.WriteLine("\nBig Feature Commit History:");
            Console.WriteLine("---------------------------");
            bigFeature.ShowDetail();

            // After both branches were merged into main
            Console.WriteLine("\nFull Commit History:");
            Console.WriteLine("--------------------");
            mainBranch.ShowDetail();
        }
    }
}
