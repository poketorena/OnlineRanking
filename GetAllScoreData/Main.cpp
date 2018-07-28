#include <Siv3D.hpp>

void Main()
{
    HTTPClient client;
    s3d::ByteArray byteArray;
    const std::string param = "";

    client.requestGET(
        URL(L"http://rankingserver20180728071716.azurewebsites.net/api/scoredata"),
        byteArray,
        L"",
        reinterpret_cast<void*>(const_cast<char*>(&param[0])),
        param.length(),
        L"Content-Type: application/x-www-form-urlencoded\r\n"
    );

    JSONReader reader(std::move(byteArray));

    for (auto index : step(reader.root().getArray().size()))
    {
        Println(L"id : " + Format(reader.root()[index][L"id"].get<long long>()));
        Println(L"name : " + reader.root()[index][L"name"].get<String>());
        Println(L"score : " + Format(reader.root()[index][L"score"].get<int>()));
        Println();
    }

    WaitKey();
}
