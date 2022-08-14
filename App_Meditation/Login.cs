using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Meditation
{
	//class Login
	//{
		//	public void Registration()
		//	{
		//		string strUserFio;  // поле ФИО
		//		string strUserAddress;  // поле Адреса
		//		string strUserPhoneNumber; // поле телефона
		//		string strUserLogin;     // поле Логин 
		//		string strUserPassword; // поле Пароль
		//		string buffer;

		//		system("cls");

		//		cout << "Введите логин: ";

		//		cin >> strUserLogin;

		//		hash<string> hesh;

		//		ifstream file;

		//		fs::create_directory("Users");

		//		file.open("Users//Admin.txt");

		//		while (!file)
		//		{

		//			if (strUserLogin == "admin")
		//			{
		//				break;
		//			}
		//			else
		//			{
		//				cout << "сначала нужно создать админа " << endl;
		//				cout << "Введите логин: ";
		//				cin >> strUserLogin;
		//			}

		//		}

		//		unsigned long strUserNameHash = hesh(strUserLogin);

		//		auto UsersCheckLogin = "Users//Users.txt";

		//		ifstream inputUCheck(UsersCheckLogin);

		//		while (inputUCheck >> buffer)
		//		{
		//			if (buffer == to_string(strUserNameHash))
		//			{
		//				cout << "Этот логин уже занят." << endl;
		//				cout << "Введите другой логин: ";
		//				cin >> strUserLogin;
		//			}
		//			else
		//			{

		//			}
		//		}

		//		inputUCheck.close();


		//		cout << "Введите пароль: ";


		//		string passw;

		//		char ch; //для скрытие пороля

		//		ch = _getch();

		//		while (ch != 13)
		//		{
		//			passw.push_back(ch);
		//			cout << ' ';
		//			ch = _getch();
		//		}
		//		cout << endl;

		//		unsigned long strUserPasswordHash = hesh(passw);

		//		cout << "Введите ФИО: ";
		//		cin >> strUserFio;

		//		regex regFIO("([\\D]*)");

		//		if (regex_match(strUserFio.c_str(), regFIO))
		//		{
		//		}
		//		else
		//		{
		//			cout << "Могут быть только буквы:" << endl;
		//			cout << "Введите ФИО еще раз: ";
		//			cin >> strUserFio;
		//		}

		//		cout << "Введите Адресс:";
		//		cin >> strUserAddress;

		//		cout << "Введите телефон: ";
		//		cout << "Шаблоны ввода: 0632518888";
		//		cin >> strUserPhoneNumber;

		//		regex regPhone("\d{9}");

		//		if (regex_match(strUserPhoneNumber.c_str(), regPhone))
		//		{
		//		}
		//		else
		//		{
		//			cout << "Могут быть только цифры и не больше 10 как указано выше!" << endl;
		//			cout << "Введите номер еще раз: ";
		//			cin >> strUserPhoneNumber;
		//		}

		//		auto Users = "Users//Users.txt";

		//		auto loginPass = "Users//" + strUserLogin + ".txt";

		//		ifstream input(Users);

		//		ifstream input1(loginPass);

		//		ofstream regOthers(loginPass, ios::app);

		//		ofstream regLP(Users, ios::app);

		//		regLP << strUserNameHash << endl << strUserPasswordHash << endl;
		//		regOthers << strUserFio << endl << strUserAddress << endl << strUserPhoneNumber << endl;

		//		system("cls");

		//		cout << "\nРегистрация заверешена... ";

		//		system("cls");
		//	}
		//       public void Login()
		//	{

		//		int count1 = 0; // Поле для проверки
		//		string user, pass; // поля чтобы логиниться
		//		string u, p; // поля чтобы проверять логины и пароли
		//		hash<string> hesh;
		//		system("cls");
		//		cout << "Введите логин: ";

		//		cin >> user;

		//		unsigned long strUserNameHash = hesh(user);

		//		cout << "Введите пароль: ";

		//		string passw;
		//		char ch; //для скрытие пороля

		//		ch = _getch();

		//		while (ch != 13)
		//		{
		//			passw.push_back(ch);
		//			cout << ' ';
		//			ch = _getch();
		//		}
		//		cout << endl;

		//		unsigned long strUserPasswordHash = hesh(passw);

		//		auto filName = "Users//Users.txt";

		//		ifstream input(filName);

		//		while (input >> u >> p)
		//		{

		//			if (u == to_string(strUserNameHash))
		//			{


		//			}
		//			if (p == to_string(strUserPasswordHash))
		//			{
		//				count1 = 1;
		//				system("cls");
		//			}

		//		}
		//		input.close();
		//		if (count1 == 1)
		//		{
		//			cout << "Привет  " << user << "\n Вы вошли";

		//			if (user == "admin")
		//			{
		//				this->users = new Admin;
		//			}
		//			else
		//			{
		//				this->users = new Student;
		//			}
		//			users->menu();
		//		}
		//		else
		//		{
		//			cout << "Неправильный логин" << endl;
		//		}
		//	}
		//}
	//}
}
