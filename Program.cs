//*****************************************************************************
//** 2491. Divide Players Into Teams of Equal Skill   leetcode               **
//*****************************************************************************


long long dividePlayers(int* skill, int skillSize) {
    long long combined = 0;
    int hashMap[1001] = {0};
    int minSkill = INT_MAX;
    int maxSkill = INT_MIN;
    for(int i = 0; i < skillSize; i++)
    {
        if(skill[i] < minSkill) minSkill = skill[i];
        if(skill[i] > maxSkill) maxSkill = skill[i];
        hashMap[skill[i]]++;
    }
    int j = minSkill;
    int k = maxSkill;
    int competitive = j + k;
    while(j <= k)
    {

        if((hashMap[j] > 0)&&(hashMap[k] > 0))
        {
            if((j + k) != competitive) return -1;
            int bin = j * k;
            combined += bin;
//            printf("hashMap[%d] = %d * hashMap[%d] = %d = bin = %d and combined = %d\n",j,hashMap[j],k,hashMap[k],bin,combined);
            hashMap[j]--;
            hashMap[k]--;
        }
        if(hashMap[j]==0) j++;
        if(hashMap[k]==0) k--;
    }

    return combined;
}