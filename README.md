# VR Space Exploration

VR Space Exploration adalah proyek pembelajaran berbasis Virtual Reality yang mengajak pengguna menjelajahi tata surya secara imersif. Pengalaman dimulai dari sebuah ruangan office, lalu pengguna berinteraksi dengan komputer untuk memulai simulasi dan berpindah ke lingkungan luar angkasa.

Project ini dirancang untuk membantu pengguna memahami karakteristik setiap planet dengan pendekatan experiential learning, sehingga proses belajar terasa lebih visual, interaktif, dan memorable dibanding pembelajaran konvensional.

## Tujuan Project

- Menyajikan pengalaman eksplorasi tata surya dalam lingkungan VR yang imersif.
- Membantu pengguna mempelajari ukuran, gravitasi, dan karakteristik unik tiap planet.
- Meningkatkan ketertarikan terhadap sains dan astronomi melalui interaksi langsung.

## Fitur Utama

- Transisi dari environment office ke simulasi luar angkasa.
- Eksplorasi planet dalam lingkungan VR 3D.
- Teleport movement untuk navigasi yang lebih nyaman.
- Opsi continuous movement untuk eksplorasi bebas.
- Interaksi menggunakan ray interactor dan direct interactor.
- Informasi edukatif planet melalui UI hologram atau narasi audio.
- Simulasi sensasi gravitasi berbeda pada tiap planet.
- Spatial audio dan feedback interaksi untuk meningkatkan imersi.

## Alur Pengalaman

1. Pengguna memulai dari scene office.
2. Pengguna mendekati komputer dan menekan tombol untuk memulai simulasi.
3. Sistem melakukan transisi teleportasi ke lingkungan luar angkasa.
4. Pengguna menjelajahi area space dan memilih planet yang ingin diamati.
5. Informasi edukatif ditampilkan melalui elemen UI atau audio.
6. Pengguna dapat kembali ke menu utama atau mengakhiri pengalaman.

## Scene Utama

Beberapa scene yang saat ini tersedia di project:

- `Assets/Scenes/Home.unity`
- `Assets/Scenes/MainMenu.unity`
- `Assets/Scenes/Space.unity`

## Teknologi yang Digunakan

- Unity `2022.3.62f3`
- Universal Render Pipeline (URP)
- XR Interaction Toolkit `2.6.5`
- XR Management `4.5.4`
- Oculus XR Plugin `4.5.4`
- Input System
- TextMeshPro
- Localization

## Target Platform

Project ini disiapkan untuk pengalaman VR 6DoF dan menargetkan ekosistem headset berbasis Oculus / Meta Quest dengan kontrol penuh pada head movement dan controller.

## Kontrol dan Interaksi

- Left hand menggunakan `Ray Interactor` untuk menunjuk UI hologram, memilih tujuan teleport, dan interaksi jarak jauh.
- Right hand menggunakan `Direct Interactor` untuk mengambil objek dan berinteraksi langsung dengan elemen virtual.
- Teleport movement diprioritaskan untuk mengurangi motion sickness.
- Continuous movement dapat digunakan sebagai opsi tambahan untuk pengguna yang sudah terbiasa dengan VR.

## Struktur Folder Penting

- `Assets/` berisi scene, model, material, prefab, dan aset project.
- `Packages/` berisi dependency Unity Package Manager.
- `ProjectSettings/` berisi konfigurasi project Unity.

## Cara Install

1. Clone repository ini:

```bash
git clone https://github.com/gbrlhf/VR-SPACE-EXPLORATION.git
```

2. Buka Unity Hub, lalu pilih `Add project` atau `Open`.
3. Arahkan ke folder hasil clone repository.
4. Pastikan project dibuka menggunakan Unity `2022.3.62f3`.
5. Tunggu Unity menyelesaikan import package dan generate file project.
6. Jika diminta untuk mengaktifkan `Input System`, pilih restart editor agar konfigurasi XR berjalan normal.

## Cara Menjalankan Project

1. Buka project ini menggunakan Unity Hub.
2. Gunakan Unity versi `2022.3.62f3`.
3. Pastikan package XR sudah terpasang sesuai `Packages/manifest.json`.
4. Buka scene `Assets/Scenes/MainMenu.unity` atau `Assets/Scenes/Home.unity`.
5. Jalankan project melalui Unity Editor atau build ke perangkat VR yang didukung.

## Cara Build ke Android / Meta Quest

1. Buka `File > Build Settings`.
2. Pilih platform `Android`, lalu klik `Switch Platform` jika belum aktif.
3. Pastikan Android Build Support untuk Unity sudah terpasang.
4. Hubungkan headset atau siapkan output APK.
5. Klik `Build` untuk menghasilkan file APK, atau `Build And Run` untuk langsung memasang ke device.

File APK build juga sudah terlihat di project ini sebagai referensi:

- `space.apk`

## Target Optimasi

Berdasarkan design document, target performa project ini adalah:

- Minimum `72 FPS`
- Waktu render di bawah `13.9 ms` per frame
- Sekitar `100,000 - 200,000` triangles per frame
- Sekitar `50 - 100` draw calls per frame

Strategi lighting yang direncanakan adalah mostly baked dengan beberapa elemen mixed lighting untuk menjaga keseimbangan antara kualitas visual dan performa.

## Status Project

Project ini masih berada pada tahap pengembangan dan penyempurnaan fitur. Fokus utama saat ini adalah eksplorasi planet, interaksi VR, kenyamanan navigasi, dan penyampaian informasi edukatif secara imersif.

## Referensi Desain

README ini disusun berdasarkan dokumen perancangan project: `Project Design Doc - VR Kelompok 5`.
