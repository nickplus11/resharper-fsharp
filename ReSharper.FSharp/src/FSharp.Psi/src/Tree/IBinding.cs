using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.FSharp.Psi.Tree
{
  public partial interface IBinding
  {
    TreeNodeCollection<IFSharpAttribute> AllAttributes { get; }
  }
}
