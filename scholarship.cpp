#include <iostream>
#include <string>

using namespace std;

int main(){

    int avg, absences;
    
    cout << "Enter average: ";
    cin >> avg;

    cout << "Enter absences: ";
    cin >> absences;

    cout << "\nScholarship Eligible: " << (avg >= 90 && absences <= 5) << endl;


}