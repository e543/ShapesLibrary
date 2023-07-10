

using ShapesLibrary;


var square = new Square(11);
IShape shape = square;
var rect = square as IShape;
Circle circle = new(10);

square.Test();
shape.Test();
circle.Test();
rect.Test();