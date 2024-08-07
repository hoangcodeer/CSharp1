/*Số phép toán cơ cấp của 2 thật toán A và B lần lượt là 8nlogn và 2n ^ 2
.Tìm số n0 sao cho A nhanh hơn B mọi n >= n0*/

#include <iostream>
#include <cmath>

int main() {
    int n0 = 4;  // Giá trị ban đầu của n0
    while (true) {
        double left_side = 8 * n0 * log2(n0); // Phép toán của thuật toán A
        double right_side = 2 * pow(n0, 2);  // Phép toán của thuật toán B

        if (left_side < right_side) {
            break;  // Thoát khỏi vòng lặp nếu A nhanh hơn B
        }

        n0++;  // Tăng giá trị của n0 nếu A chậm hơn B
    }

    std::cout << "The value of n0 is: " << n0 << std::endl;

    return 0;
}