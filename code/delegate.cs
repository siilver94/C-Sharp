private delegate void dele();

...

this.Invoke(new dele(() =>
{
}));
