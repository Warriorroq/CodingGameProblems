#include <iostream>

using namespace std;


int main()
{
    float score;
    cin >> score;
    for (float tries = 0; tries < score / 5 + 1; tries++) {
        for (float conversion = 0; conversion < tries + 1; conversion++) {
            float penalty = (score - 5 * tries - 2 * conversion) / 3;
            if (penalty >= 0 && penalty == (int)penalty)
                cout << tries << " " << conversion << " " << penalty << endl;
        }
    }
}
