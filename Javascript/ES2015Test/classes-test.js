//Exampel from: https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Classes

class Rectangle {
  constructor(height, width) {
    this.height = height;
    this.width = width;
  }
  
  get area() {
    return this.calcArea();
  }
  set setHeight(value) {
    this.height = value;
  }

  calcArea() {
    return this.height * this.width;
  }
  changeWidth(xD) {
    this.width = xD;
  }
}

const square = new Rectangle(10, 10);

console.log(square.area);

square.setHeight = 20;
console.log(square.area);
square.changeWidth(1);
console.log(square.area);
