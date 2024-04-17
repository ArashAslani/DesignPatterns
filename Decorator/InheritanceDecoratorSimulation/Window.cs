namespace Decorator.InheritanceDecoratorSimulation;

public class Window
{

}

public class GlassWindow : Window
{

}

public class ShadowWindow : Window
{

}
public class BorderWindow : Window
{

}

public class BorderGlassWindow : BorderWindow
{

}

public class ShadowGlassWindow : GlassWindow
{

}

public class BorderShadowGlassWindow : ShadowGlassWindow
{

}


