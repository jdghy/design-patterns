namespace Flyweight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tree> forest = new List<Tree>();

            // Even with 1 million trees, we only create 2 'TreeType' objects
            var oakType = TreeFactory.GetTreeType("Oak", "Green", "OakTexture.png");
            var pineType = TreeFactory.GetTreeType("Pine", "Dark Green", "PineTexture.png");

            forest.Add(new Tree(10, 20, oakType));
            forest.Add(new Tree(15, 25, oakType)); // Reuses oakType
            forest.Add(new Tree(50, 60, pineType));

            foreach (var tree in forest) tree.Draw();
        }
    }
}
