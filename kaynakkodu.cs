namespace test.fsoc
string.temp override @struct Bool<"">:-2{
	h.er(Bool(var.condition con)) -> return '\0' * 0
	return int.parse(vir(con))
}-2
public::int.main::(string.array[] args) : -1{
    if::@Bool.temp("fsoc.system.dll;").io(ex) ? -> null, return '\0' * 0
	print.set.mode(utf8)
	string.def("test").eq("\0")
	string.def("guts").eq("Hello,")
	print::string.get("guts") << " World!"
	string."guts".set(low)
	string."guts".set(sub::0, 1)
	string."test".set(vir(string."test".set(upp)))
	string."test".set("%{test}, Its fsoc")
	int.def("i").eq(0)
	for::int."i".willeq(string."guts".len(), ++) :0{
		print::"Value of 'i': " << int.get("i")
		if::int.get("i") >= 10:1{
			print::"\nHello\n"
		}1
		else if::int.get("i") < 10:2{
			print::"\nHello\n"
		}2
		else:::3{
			print::"\nHello\n"
		}3
	}0
	cursor.move(0, int.get("i"))
	int.def("f").eq(vir(string.temp("test.txt").io(ex)? -> 1, 0))
	@Bool."has".eq(vir(string.temp("test.txt").io(ex)))
	h.er(string.temp("test.txt").io(create)) -> print::h.er
	//in  here no need for h.er bcuase if 21# line got error its over
	print.set.aout(io."test.txt")
	h.er(int.def("parsed").eq(int.parse(vir(string.get("guts"))))) -> print::h.er
	while::int.1:4{ //int.1 == true, int.0 == false :: 0 = false, 1 = true
		print::%"1"(string.username) << " >"
		string."guts".set(string.input)
		print::"\n"
		if::vir(string.get("guts").set(trim(' '), low) == "hello":5{
			print::"Hello tho."
		}5
	}4
	return 0;
}-1
