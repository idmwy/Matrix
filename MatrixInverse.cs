public class MatrixInverse
{
    public static double det =0;
    public static int i =3;
    public static int j =3;
    
    //// prints out the determinant of matrix A
    private static double Determinant(int[,] A)
    {
        double d =0;
        for(int i=0;i<3;i++)
        {
		d = d + (A[0,i]*(A[1,(i+1)%3]*A[2,(i+2)%3] - A[1,(i+2)%3]*A[2,(i+1)%3]));
	}

        System.Console.Write("\nThe Determinant of the matrix is: {0}\n\n",d);
        return d;
    }
    
    //// find the inverse of the matrix A
    private static void Inverse(int[,] A)
    {
        double d = Determinant(A);
	if(d == 0)
	{
  	    	System.Console.Write("\nMatrix A is singular");
	}
    	else
    	{
	        double invdet = 1 / det;
            	double [,] result = new double[i,j];
        
            	result[0,0] =  (A[1,1]*A[2,2]-A[2,1]*A[1,2])*invdet;
            	result[0,1] = -(A[0,1]*A[2,2]-A[0,2]*A[2,1])*invdet;
            	result[0,2] =  (A[0,1]*A[1,2]-A[0,2]*A[1,1])*invdet;
            	result[1,0] = -(A[1,0]*A[2,2]-A[1,2]*A[2,0])*invdet;
            	result[1,1] =  (A[0,0]*A[2,2]-A[0,2]*A[2,0])*invdet;
           	result[1,2] = -(A[0,0]*A[1,2]-A[1,0]*A[0,2])*invdet;
            	result[2,0] =  (A[1,0]*A[2,1]-A[2,0]*A[1,1])*invdet;
            	result[2,1] = -(A[0,0]*A[2,1]-A[2,0]*A[0,1])*invdet;
            	result[2,2] =  (A[0,0]*A[1,1]-A[1,0]*A[0,1])*invdet;
        
        
            	System.Console.Write("The inverse matrix is :\n");
	        for(int i=0;i<3;i++)
	        {
	            for(int j=0;j<3 ;j++)
	                System.Console.Write("{0}  ",result[i,j]);
	                System.Console.Write("\n");
	        }
        }
    }
    
    public static void Main( )
    {
        //System.Console.WriteLine("Write your code at here");
         
       
        
        int[,] arr1 = new int[i,j];
            
        arr1[0,0]=2;//0;//2;
        arr1[0,1]=1;//1;//2;
        arr1[0,2]=0;//0;//2;
        
        arr1[1,0]=2;//1;//2;
        arr1[1,1]=0;//1;//1;
        arr1[1,2]=0;//0;//0;
        
        arr1[2,0]=2;//0;//1;
        arr1[2,1]=0;//2;//2;
        arr1[2,2]=1;//1;//0;
        
        System.Console.Write("The matrix is :\n");
 	for(i=0;i<3;i++)
	{
	        for(j=0;j<3 ;j++)
	            System.Console.Write("{0}  ",arr1[i,j]);
	            System.Console.Write("\n");
    	}
	    
	det= Determinant(arr1);  
      	Inverse(arr1);
     }
}
