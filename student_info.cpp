#include <iostream>
using namespace std;

int main(){
    string name;
    cout << "Enter your name: ";
    cin >> name;
    int age;
    cout << "Enter your age: ";
    cin >> age;
    string course;
    cout << "Enter your course: ";
    cin >> course;
    int yr_lvl;
    cout << "Enter your year level: ";
    cin >> yr_lvl;

    cout << "===== STUDENT INFORMATION =====" << endl;
    cout << "Name: " << name << endl;
    cout << "Age: " << age << endl;
    cout << "Course: " << course << endl;
    cout << "Year Level: " << yr_lvl << endl;

    return 0;

}