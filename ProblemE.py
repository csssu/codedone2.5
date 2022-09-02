''' 
 @ author :  AmirZoyber 
 language : Python3.* 
 ''' 
  
 def sort(endTime,startTime): 
     for i in range(len(endTime)): 
         for j in range(len(endTime)-i-1): 
             if (endTime[j]>endTime[j+1]): 
                 endTime[j],endTime[j+1] = endTime[j+1],endTime[j] 
                 startTime[j],startTime[j+1] = startTime[j+1],startTime[j] 
     return endTime,startTime 
  
 n = int(input()) 
 startTime = list(map(int,input().split())) 
 endTime= list(map(int,input().split())) 
  
 endTime,startTime=sort(endTime,startTime) 
  
 sum=1;count=0 
  
 for i in range(1,n): 
     if(endTime[count] <= startTime[i]): 
         sum+=1 
         count=i 
 print(sum)