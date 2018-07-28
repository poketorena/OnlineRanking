#include <Siv3D.hpp>

void Main()
{
    HTTPClient client;

    s3d::ByteArray byteArray;
    const std::string param = R"({"name":"alice","score":327})";

    client.requestPOST(
        L"http://rankingserver20180728071716.azurewebsites.net/api/scoredata",
        byteArray,
        L"",
        reinterpret_cast<void*>(const_cast<char*>(&param[0])),
        param.length(),
        L"Content-Type: application/json\r\n"
    );

    s3d::WaitKey();
}
