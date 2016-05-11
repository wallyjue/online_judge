package one;

public class LeetCode {
	public int maxProfit_121(int[] prices) {
		if(prices.length <= 1) return 0;
		int min = prices[0];
		int profit = prices[1] - prices[0];
		for(int i = 2; i < prices.length; i++){
			min = Math.min(min, prices[i-1]);
			profit = Math.max( profit, prices[i]- min);
		}
		if(profit < 0) return 0;
		return profit;
	}
	
	public int maxProfit_122(int[] prices){
		if(prices.length <= 1) return 0;
		int profit = 0, buyprice = 0;
		for(int i = 0; i < prices.length; i++){
			if(i+1 <= prices.length && prices[i+1] > prices[i]){
				buyprice = prices[i];
				//buy at day i
			}else{
				profit = profit + prices[i] - buyprice;
				//sell at day i
			}
		}
		if(profit < 0) return 0;
		return profit;
	}
	public int uniquePaths(int m, int n) {
		int ret = 0;
		//dp[m][n] = dp[m-1][n] + dp[m][n-1]
		int[][] dp = new int[m][n];
		for(int i = 0; i < m ; i++){
			dp[i][0] = 1;
		}
		for(int i = 0; i < n ; i++){
			dp[0][i] = 1;
		}
		
		for(int i = 1; i < m; i++){
			for(int j = 1; j < n; j++){
				dp[i][j] = dp[i-1][j] + dp[i][j-1];
			}
		}
		
		return dp[m-1][n-1];
    }
	
	public int uniquePathsWithObstacles(int[][] obstacleGrid) {
		// if obstacle at x,y
		// then dp[x+1][y] = dp[y] && dp[y+1] = dp[x]
		
		int ret = 0;
		//dp[m][n] = dp[m-1][n] + dp[m][n-1]
		int m = obstacleGrid.length;
		int n = obstacleGrid[0].length;
		int[][] dp = new int[m][n];
		for(int i = 0; i < m ; i++){
			if(obstacleGrid[i][0] == 0){
				dp[i][0] = 1;
			}else{
				break;
			}
		}
		for(int i = 0; i < n ; i++){
			if(obstacleGrid[0][i] == 0){
				dp[0][i] = 1;
			}else{
				break;
			}
		}
		
		for(int i = 1; i < m; i++){
			for(int j = 1; j < n; j++){
				if(obstacleGrid[i][j] == 1){
					dp[i][j] = 0;
				}else{
					dp[i][j] = dp[i-1][j] + dp[i][j-1];
				}
				
			}
		}
		
		return dp[m-1][n-1];
		
    }
	
}
