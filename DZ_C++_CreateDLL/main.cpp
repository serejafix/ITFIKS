// DZ_C++_CreateDLL.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include <iostream>
    int main()
    {

    }

    __declspec(dllexport)
    static double triangle(double a, double b, double c)
    {
        double p, s;
        p = (a + b + c) / 2;
        s = pow(p * (p - a) * (p - b) * (p - c), 0.5);
        return s;
    }
    __declspec(dllexport)
    static double rectangle(int sideA, int sideB)
    {
        int area;
        area = sideA * sideB;
        return area;
    }
    __declspec(dllexport)
    static double square(int side)
    {
        int area;
        area = side * side;
        return area;
    }

