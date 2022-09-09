	public class Solution {
	    public bool ValidPath(int n, int[][] edges, int source, int destination)
	{
		var graph = buildGraph(edges, n);
		if (graph[source].Contains(destination)) 
	        return true;
	        
		var visited = new bool[n];
		// start traveling from the source
		dfs(graph, source, visited);
		// last thing to do is to check if we visited destionation node
		return visited[destination];
	}
	
	
	// Travers all reachable nodes from the currentNode position
	// and sets the visited node to true in the visited bool array 
	void dfs(Dictionary<int, List<int>> graph, int currentNode, bool[] visited)
	{
		if (visited[currentNode]) return;
		visited[currentNode] = true;
		foreach (var node in graph[currentNode])
		{                
			dfs(graph, node, visited);
		}
	}
	
	
	// Builds a graph from the 2-dimensional array
	// The key of dictionary will be the node and the value(list elements) will be the nodes that can be traveled to from the key node
	Dictionary<int, List<int>> buildGraph(int[][] edges, int n)
	{
		Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
		for (var i = 0; i < n; ++i)
			graph.Add(i, new List<int>());
	
		foreach(var edge in edges)
		{
		    // This is an undirected graph, so in case of [0,1], 
			// theres a path from 0 to 1 and also from 1 to 0. That's why the following two lines.
			graph[edge[0]].Add(edge[1]);
			graph[edge[1]].Add(edge[0]);
		}           
		return graph;
	}
	}