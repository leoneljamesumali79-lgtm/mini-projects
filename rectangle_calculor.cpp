#include <iostream>
#include <string>

using namespace std;

int main(){
    int length;
    cout << "Enter length: ";
    cin >> length;

    int width;
    cout << "Enter width: ";
    cin >> width;

    int area = length * width;
    int perimeter = 2 * (length + width);

    cout << "Area: " << area << endl;
    cout << "Perimeter: " << perimeter << endl;
    


    return 0;
}