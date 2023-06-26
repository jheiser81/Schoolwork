using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SongsAndPlaylist.Data;
using SongsAndPlaylist.Models;

namespace SongsAndPlaylist.Controllers
{
    public class PlaylistSongsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PlaylistSongsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PlaylistSongs
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PlaylistSongs.Include(p => p.Playlist).Include(p => p.Song);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PlaylistSongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.PlaylistSongs == null)
            {
                return NotFound();
            }

            var playlistSong = await _context.PlaylistSongs
                .Include(p => p.Playlist)
                .Include(p => p.Song)
                .FirstOrDefaultAsync(m => m.PlaylistId == id);
            if (playlistSong == null)
            {
                return NotFound();
            }

            return View(playlistSong);
        }

        public async Task<IActionResult> PlaylistSongs(int id)
        {
            var songs = await _context.PlaylistSongs
                .Include(ps => ps.Song)
                .Where(ps => ps.PlaylistId == id)
                .Select(ps => ps.Song)
                .ToListAsync();

            if (songs == null)
            {
                return NotFound();
            }

            ViewBag.PlaylistName = _context.Playlists.FirstOrDefault(p => p.PlaylistId == id)?.Name;
            return View(songs);
        }

        //make a removeSongFromPlaylist method
        public async Task<IActionResult> RemoveSongFromPlaylist(int id, int playlistId)
        {
            var playlistSong = await _context.PlaylistSongs
                .FirstOrDefaultAsync(ps => ps.SongId == id && ps.PlaylistId == playlistId);
            if (playlistSong == null)
            {
                return NotFound();
            }
            _context.PlaylistSongs.Remove(playlistSong);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(PlaylistSongs), new { id = playlistId });
        }

        // GET: PlaylistSongs/Create

        public IActionResult Create()
        {
            ViewData["PlaylistId"] = new SelectList(_context.Playlists, "PlaylistId", "Name");
            ViewData["SongId"] = new SelectList(_context.Songs, "SongId", "Title");
            return View();
        }

        // POST: PlaylistSongs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PlaylistSongId,PlaylistId,SongId")] PlaylistSong playlistSong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(playlistSong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlaylistId"] = new SelectList(_context.Playlists, "PlaylistId", "Name", playlistSong.PlaylistId);
            ViewData["SongId"] = new SelectList(_context.Songs, "SongId", "Title", playlistSong.SongId);
            return View(playlistSong);
        }

        // GET: PlaylistSongs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.PlaylistSongs == null)
            {
                return NotFound();
            }

            var playlistSong = await _context.PlaylistSongs.FindAsync(id);
            if (playlistSong == null)
            {
                return NotFound();
            }
            ViewData["PlaylistId"] = new SelectList(_context.Playlists, "PlaylistId", "Name", playlistSong.PlaylistId);
            ViewData["SongId"] = new SelectList(_context.Songs, "SongId", "Title", playlistSong.SongId);
            return View(playlistSong);
        }

        // POST: PlaylistSongs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PlaylistSongId,PlaylistId,SongId")] PlaylistSong playlistSong)
        {
            if (id != playlistSong.PlaylistId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(playlistSong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PlaylistSongExists(playlistSong.PlaylistId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["PlaylistId"] = new SelectList(_context.Playlists, "PlaylistId", "Name", playlistSong.PlaylistId);
            ViewData["SongId"] = new SelectList(_context.Songs, "SongId", "Title", playlistSong.SongId);
            return View(playlistSong);
        }

        // GET: PlaylistSongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.PlaylistSongs == null)
            {
                return NotFound();
            }

            var playlistSong = await _context.PlaylistSongs
                .Include(p => p.Playlist)
                .Include(p => p.Song)
                .FirstOrDefaultAsync(m => m.PlaylistId == id);
            if (playlistSong == null)
            {
                return NotFound();
            }

            return View(playlistSong);
        }

        // POST: PlaylistSongs/Delete/5
        //make delete post method, so that the delete button works
        //delete  button should delete the song from the playlist when clicked

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int PlaylistId, int SongId)
        {
            if (_context.PlaylistSongs == null)
            {
                return Problem("Entity set 'ApplicationDbContext.PlaylistSongs'  is null.");
            }
            var playlistSong = await _context.PlaylistSongs.FindAsync(PlaylistId, SongId);
            if (playlistSong != null)
            {
                _context.PlaylistSongs.Remove(playlistSong);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PlaylistSongExists(int id)
        {
            return (_context.PlaylistSongs?.Any(e => e.PlaylistId == id)).GetValueOrDefault();
        }
    }
}