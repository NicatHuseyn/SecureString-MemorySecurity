
   <h1 style="text-align: center">
      SecureString Class-ı İlə Memory Təhlükəsizliyi
    </h1>
    <h3><strong>Memory Güvənliyini təmin etmək nədir?</strong></h3>
    <p>
      Üstündə çalışdığımız bir proyektdə həm user-lər üçün həm də proqram üçün
      çox önəmli datalarla işləyə bilərik. Bu datalar, user-lərə aid kimlik və
      kart məlumatları ola bilər, həmçinin proqrama aid, connection, port yaxud
      hər hansı bir dövlət sirri ola bilər.
      <br />
      Çox developer normal olaraq bu dataları string olaraq tutacaq və istifadə
      edəcək. Bu kimi string ifadələri bir dəyişgənlərlə memory-də tutduğumuz
      üçün burada bir güvənlik təhlükəsi vardır.
      <br />
      <strong
        >Bəs bu datalar istifadə ediləndə kompüterin harasında
        saxlanılacaq?</strong
      >
      <br />
      Sözüz ki, dəyişgən istifadə edəcəyimiz üçün bu datalar kompüterin
      memory-sində saxlanılacaq.
      <br />
      Texniki olaraq proqramda istifadə olunan dəyişgənlər memory-də
      saxlanılacağı üçün, 2-ci və 3-cü şəxslərin memory-ə girib önəmli dataları
      görmə ehtumalı vardır. Uzun sözün qısası memory-də saxlanılan datalarda
      bir güvənlik problemi ehtimalı vardır.
      <br />
      Görüldüyü kimi vacib dataların üzərində əməliyyatlar aparan zaman güvənlik
      probleminə qarşı tədbir almağımız və bu dəyişgənləri güvənli bir halda
      şifrələyərək qorumalıyıq. Əks halda bir güvənlik problemi ola bilər.
      <br />
      İndi biz özümüz bu önəmli dataları maual olaraq şifrələməyi fikiləşə
      bilərik. Amma bu işə yaramayacaq. Çünki biz özümüz string bir datanı
      manipuliyasiay etmək istəyə bilərik, amma string ifadələrin memory
      strukturundakı funksionallığına görə.
      <br />
      Bildiyimiz kimi string ifadələrin üzərində edilən dəyişikliklər, onun
      clone-u üzərində olur, birbaşa datanın üzərində olmur.
      <br />
      Bilirik ki, string ifadələr normalda immutable strukturlardır. Yəni string
      bir ifadədə edilən hər hansı bir dəyişiklik, bir əməliyyat (əlavə etmə,
      çıxarma, dəyişdirmə) birbaşa dəyişgənin yaddaşdakı fiziki strukturuna
      təsir etməyəcək, əlaqəli dəyişgənin bir kopyası yaradılacaq və onun
      üstündə həyata keçiriləcək. Uzun sözün qısası, bu əməliyyat nəticəsində
      memory-də dəyişənin köhnə dəyərinin olduğu kimi yaddaşdaki əlaqəli
      adressdə qaldığını deyə bilərik.
      <br />
      Belə bir halda vacib dataların tutulduğu dəyişgənin üstündə nə ediriksə
      edək orginal hallarının bir üsulla saxlanılacağını və bunlara hər zaman
      daxil olma ehtimalını deyə bilərik. O zamana ki, SecureString
      çalışmalarımızı yerinə yetirənə kimi.
    </p>
    <br />
    <br />

  <h1 style="text-align: center">
      <strong>SecureString Class-ı Nədir</strong>
    </h1>
    <p>
      SecureString class-ı, C# proqramlaşdırma dilində həssas dataların güvənli
      bir şəkildə əməliyyata salınması üçün istifadə edilən bir data tipidir.
      Təməl məqsədi, yaddaşdaki string dataların güvənliyini artırmaqdır.
      <br />
      SecureString obyekti ilə bir string data yaddaşda şifrələnir və bu dataya
      sadəcə class-a xas olan üsullarla daxil oluna bilər (əldə edilə bilər.).
      Bu normal bir string dəyərinin yaddaşda olduğu kimi açıq bir şəkildə
      saxlanılmasının əksinə daha güvənli bir üsul verir bizə.
      <br />
      SecureString, adətən user kimlik bilgiləri kimi vacib dataların istifadə
      olunduğu proqramlarda istifadə edilir. Özəlliklə şifrələrin, APİ keylərin
      yaxud digər kimlik doğrulama datalarının güvənli şəkildə əməliyyata
      soxulması hallarında istifadə edilir.
      <br />
      SecureString class-ı ilə müdaxilə edilən dəyişənlər yaddaşda
      <br />
      <strong>
        DP APİ (Data Protection APİ) ilə şifrəli halda saxlanılır. Həmçinin
        dəyişənin dəyərində edilən hər hansı bir dəyişiklik, dəyişənin kopyasını
        yaratmadan, birbaşa yaddaşdakı fiziki dəyişənə təsirini göstərir.
      </strong>
    </p>
    <br />
    <br />

  <h3>Bu işlərə misal olaraq:</h3>
    <p>
      Mail göndərmə zamanı istifadə etdiyimiz NetworkCredential classı,
      SecureString ilə dəyər aldığı bir overload-a sahibdir. Çünki bu class
      username və password kimi vacib datalar ilə çalışır.
    </p>

  <div style="width: 700px">
      <img src="https://github.com/user-attachments/assets/9c5b8ee1-0deb-4b4b-9e90-a5139312ee87" style="width: 700px" alt="" />
    </div>
    <p>Görüldüyü kimi 3-cü overload-da SecureString olaraq verə bilirik.</p>

  <br />
    <br />

  <h3>Nümunələr:</h3>
    <br />
    <strong>Network API İstəkləri:</strong>
    <p>
      Bəzi proqramlarda bir APİ istək atıqda username və password kimi datalar
      SecureString ilə şifrələnir.
    </p>
    <br />

  <div style="width: 500px">
      <img src="https://github.com/user-attachments/assets/3fc8e3b9-159c-42f5-9f47-54c1fa09ff70" style="width: 500px" alt="" />
    </div>

  <br />
    Bu şəkildə kod yazaraq string ifadəni şifrələyirik.
    <br />
    <br />
    <h1 style="text-align: center">
      SecureString Class-ı İlə Qorununan Dataların Runtime-da Əldə Edilməsi
    </h1>

  <ul>
      <ol>
        <div style="width: 500px">
          <img src="https://github.com/user-attachments/assets/5f89ae95-1559-46cb-8d2c-0f02422e21cd" style="width: 500px" alt="" />
        </div>
      </ol>
      <ol>
        <div style="width: 500px">
          <img src="https://github.com/user-attachments/assets/f9f7b960-38ef-49a0-8a77-8ef5311b0bd5" style="width: 500px" alt="" />
        </div>
      </ol>
      <ol>
        <div style="width: 500px">
          <img src="https://github.com/user-attachments/assets/1c81104d-a810-4c89-9cf6-bf12735340e8" style="width: 500px" alt="" />
        </div>
      </ol>
    </ul>

  <br />
    <br />
    <p>
      Nəticədə deyə bilərik ki, SecureString ilə vacib dataların yaddaşda düzgün
      bir şəkildə saxlamaq bir güvənlik problemidir. Bu halda SecureString ilə
      işimizi sağlam görə bilər və datalarımızı qoruya bilərik.
    </p>
