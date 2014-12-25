<html>
	<head>
		<title>Loops - ASP</title>
	</head>
	<body>
		<%
			Dim i,j
			j = CInt(Request.querystring("thevar"))
			For i = 0 to (j - 1) step 1
				Dim color
				select case ((i mod 5) + 1)
					case 1
						color = "green"
					case 2
						color = "red"
					case 3
						color = "blue"
					case 4
						color = "black"
					case 5
						color = "lightblue"
				end select
				Dim toshow
				toshow = "<b><font face='Arial' size='2' color='" & color & "'>"_
				& (i + 1) & "</font></b>  "
				Response.write toshow
			Next
		%>
		<font face="Arial" size="1">Made by Omri.</font>
	</body>
</html>