void Main()
{
	
	 	int n= 5;
	 	int[] a=new int[n+1]; 
		a[0]=1;
		int total;
		int[] range=new int[]{1,3,5}; 
		int i;
		if(n==0)
			Console.WriteLine(a[0]);
		else{
			for(i=1;i<=n;i++){	
				total=0;
				foreach (int j in range){			
					if(i-j>=0)
						total += a[i-j];	
					a[i]=total;	
		  		}
		  		
			}
			Console.WriteLine(a);
		}		
}

