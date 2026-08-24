#include <iostream>
#include <string>

using namespace std;

int main(){
    int order_total, member;

    cout << "Enter order total: ";
    cin >> order_total;

    cout << "Are you a member? ";
    cin >> member;

    cout << "\nFree Shipping: " << (order_total >= 1000 || member == 1) << endl;

}