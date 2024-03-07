using StructuralPatterns.Adapter;
using StructuralPatterns.Bridge;

#region Adapter
Console.WriteLine("Adapter Pattern\n");

VGACable vgaCable = new VGACable();
VGAToDVIAdapter vgaAdaptedToDvi = new VGAToDVIAdapter(vgaCable);

Console.WriteLine(vgaAdaptedToDvi.ReceiveDigitalVideoData());

Console.WriteLine("--------------------------------");
#endregion

#region Bridge
Console.WriteLine("Bridge Pattern\n");

RubySkin rubySkin = new RubySkin("Basic Ruby");
GoldSkin goldSkin = new GoldSkin("Premium Gold");
Character character1 = new Character(rubySkin);

Console.WriteLine("Using: "+character1.Skin.Name);
character1.ApplySkin();
character1.RemoveSkin();
character1.ApplySkin();

character1.Skin = goldSkin;
Console.WriteLine("Using: "+character1.Skin.Name);
character1.ApplySkin();

Console.WriteLine("--------------------------------");
#endregion