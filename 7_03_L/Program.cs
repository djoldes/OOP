Stack<int> st = new Stack<int>();
for(int i = 0; i < 10; i++)
{
    st.Push(i); 
}
while(st.Count > 0)
{
    Console.WriteLine(st.Pop());
}
try
{
    st.Pop();
}
catch(InvalidOperationException e)
{
    Console.WriteLine(e.Message);
}
int result;
bool ok = st.TryPop(out result);
if (ok)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Pop failed. Stack empty");
}
st.