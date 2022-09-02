/**
 * @file ProblemFifth.cpp
 * @author @mahdimma
 * @brief
 * @version 0.1.0
 * @date 2022-08-28
 *
 * @copyright Copyright (c) 2022
 *
 */

#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

vector<pair<int, int>> vect;
int startTime[1000];

int main()
{
  int N;
  cin >> N;
  for (int i = 0; i < N; i++)
  {
    cin >> startTime[i];
  }
  int endTime = 0;
  for (int i = 0; i < N; i++)
  {
    cin >> endTime;
    vect.push_back(make_pair(endTime, startTime[i]));
  }
  sort(vect.begin(), vect.end());
  int sum = 1;
  int endT = vect[0].first;
  for (int i = 1; i < N; i++)
  {
    if (endT <= vect[i].second)
    {
      endT = vect[i].first;
      sum++;
    }
  }
  cout << sum;
}