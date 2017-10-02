using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class Program
    {
        static void Main(string[] args)
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            var pf = new BadFilter();
            Console.WriteLine("Green product (old):");

            foreach (var p in pf.FilterByColor(products, Color.Green))
            {
                Console.WriteLine($"- {p.Name} is Green");
            }

            var bf = new GoodFilter();
            Console.WriteLine("Green product (new):");

            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($"- {p.Name} is Green");
            }

            Console.WriteLine("Large blue items:");

            foreach (var p in bf.Filter(
                products,
                new AndSpecification<Product>(
                    new ColorSpecification(Color.Blue),
                    new SizeSpecification(Size.Large))))
            {
                Console.WriteLine($" - { p.Name } is big and blue");
            }
        }
    }

    //public enum Color
    //{
    //    Red, Green, Blue
    //}

    //public enum Size
    //{
    //    Small, Mediem, Large, Yuge
    //}

    //public class Product
    //{
    //    public string Name { get; set; }
    //    public Color Color { get; set; }
    //    public Size Size { get; set; }

    //    public Product(string name, Color color, Size size)
    //    {
    //        Name = name;
    //        Color = color;
    //        Size = size;
    //    }
    //}

    //public class ProductFilter
    //{
    //    public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
    //    {
    //        foreach (var p in products)
    //            if (p.Size == size)
    //                yield return p;
    //    }

    //    public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
    //    {
    //        foreach (var p in products)
    //            if (p.Color == color)
    //                yield return p;
    //    }

    //    public IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products,Size size,Color color)
    //    {
    //        foreach (var p in products)
    //            if (p.Size ==size && p.Color == color)
    //                yield return p;
    //    }
    //}

    //public interface ISpecification<T>
    //{
    //    bool IsStatisfied(T t);
    //}

    //public interface IFilter<T>
    //{
    //    IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> specification);
    //}

    //public class ColorSpecification : ISpecification<Product>
    //{
    //    private Color _color;

    //    public ColorSpecification(Color color)
    //    {
    //        _color = color;
    //    }

    //    public bool IsStatisfied(Product t)
    //    {
    //        return t.Color == _color;
    //    }
    //}

    //public class SizeSpecification : ISpecification<Product>
    //{
    //    private Size _size;

    //    public SizeSpecification(Size size)
    //    {
    //        _size = size;
    //    }

    //    public bool IsStatisfied(Product t)
    //    {
    //        return t.Size == _size;
    //    }
    //}

    //public class AndSpecification<T> : ISpecification<T>
    //{
    //    private ISpecification<T> first, second;

    //    public AndSpecification(ISpecification<T> first,ISpecification<T> second)
    //    {
    //        this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
    //        this.second = second ?? throw new ArgumentNullException(paramName: nameof(first));
    //    }

    //    public bool IsStatisfied(T t)
    //    {
    //        return first.IsStatisfied(t) && second.IsStatisfied(t);
    //    }
    //}

    //public class BatterFilter : IFilter<Product>
    //{
    //    public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> specification)
    //    {
    //        foreach (var i in items)
    //            if (specification.IsStatisfied(i))
    //                yield return i;
    //    }
    //}
}
