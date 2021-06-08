#include<thread>
#include<iostream>
#include<mutex>
#include<iostream>
#include<vector>
#include<array>
#include<queue>
#include<deque>
#include<map>
#include<set>
#include<list>
#include<stack>
#include<string>
#include<cassert>


class Ressource {
	std::mutex verrou;
public:

	void ecrire(int v) {
		for (int i = 0; i < 5; i++){
			//verrou.lock();
			if (verrou.try_lock()) {
				std::cout << "le thread " << std::this_thread::get_id() << " est entrain d'ecrire " << std::endl;
				verrou.unlock();
			}
			else {
				std::cout << "le thread " << std::this_thread::get_id() << " impossible d'ecrire " << std::endl;

			}
			std::this_thread::sleep_for(std::chrono::seconds(v));
		}
	}
	void lire(int v) {
		for (int i = 0; i < 5; i++) {
			verrou.lock();
			std::cout << " le thread " << std::this_thread::get_id() << " est entrain de lire " << std::endl;
			verrou.unlock();
			std::this_thread::sleep_for(std::chrono::seconds(v));
		}
	}
};
 
void fonction(Ressource& res, int v) {
	res.ecrire(v);
	res.lire(v);
}

// les foncteurs et les predicats
/*class testvoyelles
{
public:
	bool operator()(const std::string& chaine) const
	{
		for (int i(0); i < chaine.size(); ++i)
		{
			switch (chaine[i])
			{
			case 'a':
			case 'e':
			case 'i':
			case 'o':
			case 'u':
			case 'y':
				return true;
			default:
				break;
			}
			

		}
		return false;
	}
};*/

/*class reversemaporder
{
public:

	bool operator()(const std::string& a, const std::string& b)
	{
		return a.length() < b.length();
	}
};*/

int main()
{
	/*Ressource res;

	std::thread t1(fonction, std::ref(res), 1);
	std::thread t2(fonction, std::ref(res), 2);

	t1.join();
	t2.join();*/

	// **********les conteneurs***********************

	//std::array<int, 4> myarray={1,2,4,6};


	std::vector<std::string> myvector(4,"zazi");
	myvector.push_back("toto");
	myvector.push_back("tata");
	myvector.insert(myvector.begin(), "titi");
	myvector.insert(myvector.end(), "zozo");

	for (std::vector<std::string>::iterator it = myvector.begin(); it != myvector.end(); ++it)
	{
		std::cout << *it << " " << std::endl;
	}
	myvector.erase(myvector.begin());
	std::cout << " le resultat apres le erase : " << std::endl;

	for (std::vector<std::string>::iterator it = myvector.begin(); it != myvector.end(); ++it)
	{
		std::cout << *it << " " << std::endl;
	}

	// les listes

	std::list<int> maliste(4, 12);
	maliste.push_front(1);
	maliste.push_back(13);
	for (std::list<int>::iterator it = maliste.begin(); it != maliste.end(); ++it)
	{
		std::cout << *it << std::endl;
	}

	// les map
	std::map<std::string, double/*reversemaporder*/> poids;
	poids["souris"] = 0.6;
	poids["chat"] = 3;
	poids["tigre"] = 200;
	poids["elephant"] = 1000;
	poids.insert(std::make_pair("Lion", (500)));
	for (std::map<std::string, double>::iterator it = poids.begin(); it != poids.end(); ++it)
	{
		std::cout << it->first << " pese " << it->second << " kg " << std::endl;
	}

	std::map<std::string, double>::iterator trouve = poids.find("chien");
	if (trouve == poids.end())
	{
		std::cout << " le poids du chien n'est pas dans la table" << std::endl;
	}
	else
	{
		std::cout << "le chien pese" << trouve->second << " kg " << std::endl;
	}

	// Utilisation des Fermetures 
	int some(0);
	std::function<void(std::vector<int>)> someVecteur = [&some](std::vector<int> vecteur) {
		for (int&x : vecteur) {
			some += x;
		}
	};

	std::vector<int> nombres = { 1,2,3,4,5,6,7,67,52,30 };
	someVecteur(nombres);
	std::cout <<"la somme est :"<< some << std::endl;

	getchar();
	return 0;
}
